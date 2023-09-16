using MyBikesFactory.Business;
using MyBikesFactory.Business.Enums;
using MyBikesFactory.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactory.UI
{
    public partial class MainForm : Form
    {
        private List<Bikes> listOfBikes = BikesXmlData.Load();

        public MainForm()
        {
            InitializeComponent();
            RefreshDisplayList();
        }

        #region Support Methods
        private Bikes? FindBikesById(int serialnumber)
        {
            Bikes? bikesFound = null;
            foreach (var bikes in listOfBikes)
            {
                if (bikes.Serialnumber == serialnumber)
                {
                    bikesFound = bikes;
                    break;
                }
            }

            return bikesFound;
        }

        private Bikes? FindBikesBySerialNumber2(int serialnumber)
        {
            foreach (var bikes in listOfBikes)
            {
                if (bikes.Serialnumber == serialnumber)
                    return bikes;
            }

            return null;
        }

        private Bikes? FindBikesById3(int serialnumber)
        {
            foreach (var bikes in listOfBikes)
            {
                if (bikes.Serialnumber == serialnumber)
                    return bikes;
            }

            return null;
        }

        private void RefreshDisplayList()
        {
            lstBikes.Items.Clear();

            foreach (var bikes in listOfBikes)
            {
                bool include = false;

                if (rbAll.Checked)
                    include = true;
                else if (rbRoad.Checked && bikes is RoadBikes)
                    include = true;
                else if (rbMountain.Checked && bikes is MountainBikes)
                    include = true;

                if (include)
                {
                    lstBikes.Items.Add(bikes.ToString());
                }
            }
        }

        private bool AllFieldsAreOk()
        {
            if (cbBikeType.Text == "")
            {
                MessageBox.Show("Please select a bike type");
                return false;
            }
            else if (txtSerialNumber.Text == "" || !Validator.ValidateId(txtSerialNumber.Text))
            {
                MessageBox.Show("Id is required and should contain numbers only");
                return false;
            }
           
            else if (txtModel.Text == "")
            {
                MessageBox.Show("Please inform a model");
                return false;
            }
            else if (!Validator.ValidateModel(txtModel.Text))
            {
                MessageBox.Show("Model should contain 5 characters (numbers or letters)");
                return false;
            }
            else if (txtManufacturingyear.Text == "")
            {
                MessageBox.Show("Please inform a Manufacturing Year");
                return false;
            }
            else if (!Validator.ValidateManufacturingYear(txtManufacturingyear.Text))
            {
                MessageBox.Show("Manufacturing Year should contain 4 digit");
                return false;
            }
            else if (cbColor.Text == "")
            {
                MessageBox.Show("Please select a color");
                return false;
            }
            
            else if (cbBikeType.Text == "Road" && cbTireType.Text == "")
            {
                MessageBox.Show("Please select a tire type");
                return false;
            }
            else if (cbBikeType.Text == "Mountain" && cbSuspensionType.Text == "")
            {
                MessageBox.Show("Please select a suspension type");
                return false;
            }
            return true;
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
                return;
            else if (!Validator.ValidateUniqueId(txtSerialNumber.Text, listOfBikes))
            {
                MessageBox.Show("This Serial Number is already used");
                return;
            }

            Bikes bikesToAdd;
            if (cbBikeType.Text == "Mountain")
            {
                ESuspensionType suspensionType;
                if (cbSuspensionType.Text == "Front")
                    suspensionType = ESuspensionType.Front;
                else if (cbSuspensionType.Text == "Rear")
                    suspensionType = ESuspensionType.Rear;
                else
                    suspensionType = ESuspensionType.Dual;
                //EBrakeType brakeType = (EBrakeType)Enum.Parse(typeof(EBrakeType), cbSkateType.Text);
                bikesToAdd = new MountainBikes(suspensionType);
            }
            else
            {
                ETireType tireType;
                if (cbTireType.Text == "Regular")
                    tireType = ETireType.Regular;
                else if (cbTireType.Text == "Commuter")
                    tireType = ETireType.Commuter;
                else
                    tireType = ETireType.Gravel;
                bikesToAdd = new RoadBikes(tireType);
            }

            bikesToAdd.Serialnumber = Convert.ToInt32(txtSerialNumber.Text);
            //skateboardToAdd.Name = txtName.Text;
            bikesToAdd.Model = txtModel.Text;
            // skateboardToAdd.Weight = Convert.ToSingle(txtWeight.Text);

            if (cbColor.Text == "Blue")
                bikesToAdd.Color = EColor.Blue;
            else if (cbColor.Text == "Green")
                bikesToAdd.Color = EColor.Green;
            else if (cbColor.Text == "Black")
                bikesToAdd.Color = EColor.Black;
            else
                bikesToAdd.Color = EColor.Red;
            //skateboardToAdd.Color = (EColor)Enum.Parse(typeof(EColor), cbColor.Text);

            listOfBikes.Add(bikesToAdd);

            cbBikeType.SelectedIndex = -1;
            txtSerialNumber.Text = "";
            //  txtName.Text = "";
            txtModel.Text = "";
            cbColor.SelectedIndex = -1;
            // txtWeight.Text = "";
            cbSuspensionType.SelectedIndex = -1;
            cbTireType.SelectedIndex = -1;

            RefreshDisplayList();

            MessageBox.Show("The Bike has been added");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BikesXmlData.Save(listOfBikes);

            MessageBox.Show("The list of skateboards has been saved");
        }

        private void cbSkateType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBikeType.Text == "Road")
            {
                cbSuspensionType.Enabled = true;
                cbTireType.Enabled = false;
                cbSuspensionType.SelectedIndex = 0;
                cbTireType.SelectedIndex = -1;
            }
            else
            {
                cbSuspensionType.Enabled = false;
                cbTireType.Enabled = true;
                cbSuspensionType.SelectedIndex = -1;
                cbTireType.SelectedIndex = 0;
            }
        }

        
       

        private void cbSkateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBikeType.Text == "Road")
            {
                cbSuspensionType.Enabled = true;
                cbTireType.Enabled = false;
                cbSuspensionType.SelectedIndex = 0;
                cbTireType.SelectedIndex = -1;
            }
            else
            {
                cbSuspensionType.Enabled = false;
                cbTireType.Enabled = true;
                cbSuspensionType.SelectedIndex = -1;
                cbTireType.SelectedIndex = 0;
            }
        }

      

        

        
        

        private void lstBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBikes.SelectedIndex < 0)
                return;

            var bikes = listOfBikes[lstBikes.SelectedIndex];
            if (bikes is RoadBikes)
            {
                cbBikeType.SelectedIndex = 0;
                var bikesAsElectric = (RoadBikes)bikes;
                cbTireType.SelectedIndex = (int)bikesAsElectric.TireType;
            }
            else
            {
                cbSuspensionType.SelectedIndex = 1;
                var skateboardAsRegular = (MountainBikes)bikes;
                cbSuspensionType.SelectedIndex = (int)skateboardAsRegular.SuspensionType;
            }

            txtSerialNumber.Text = bikes.Serialnumber.ToString();
            txtOriginalId.Text = txtSerialNumber.Text;
            //txtName.Text = skateboard.Name;
            txtModel.Text = bikes.Model;
            cbColor.SelectedIndex = (int)bikes.Color;
            // txtWeight.Text = skateboard.Weight.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
                return;
            else if (!Validator.ValidateUniqueId(txtSerialNumber.Text, listOfBikes))
            {
                MessageBox.Show("This id is already used");
                return;
            }
            Bikes bikesToAdd;
            if (cbBikeType.Text == "Mountain")
            {
                ESuspensionType suspensionType;
                if (cbSuspensionType.Text == "Front")
                {
                    suspensionType = ESuspensionType.Front;
                }
                else if (cbSuspensionType.Text == "Rear")
                {
                    suspensionType = ESuspensionType.Rear;
                }
                else
                {
                    suspensionType = ESuspensionType.Dual;
                }
                bikesToAdd = new MountainBikes(suspensionType);
            }
            
            else
            {
                ETireType tireType;
                if (cbTireType.Text == "Regular")
                {
                    tireType = ETireType.Regular;
                }



                else if (cbTireType.Text == "Commuter")
                {
                    tireType = ETireType.Commuter;
                }
                else
                {
                    tireType = ETireType.Gravel;

                }

                bikesToAdd = new RoadBikes(tireType);
            }


                bikesToAdd.Serialnumber = Convert.ToInt32(txtSerialNumber.Text);
                // bikesToUpdate.Name = txtName.Text;
                bikesToAdd.Model = txtModel.Text;
                bikesToAdd.Manufacturingyear = Convert.ToInt32(txtManufacturingyear.Text);
                //  skateboardToUpdate.Weight = Convert.ToSingle(txtWeight.Text);

                if (cbColor.Text == "Blue")
                    bikesToAdd.Color = EColor.Blue;
                else if (cbColor.Text == "Green")
                    bikesToAdd.Color = EColor.Green;
                else if (cbColor.Text == "Black")
                    bikesToAdd.Color = EColor.Black;
                else
                    bikesToAdd.Color = EColor.Red;
                listOfBikes.Add(bikesToAdd);

                cbBikeType.SelectedIndex = -1;
                txtSerialNumber.Text = "";
                //txtName.Text = "";
                txtModel.Text = "";
                cbColor.SelectedIndex = -1;
                // txtWeight.Text = "";
                cbSuspensionType.SelectedIndex = -1;
                cbTireType.SelectedIndex = -1;
                //skateboardToUpdate.Color = (EColor)Enum.Parse(typeof(EColor), cbColor.Text);

                RefreshDisplayList();
                MessageBox.Show("The bike has been added");


            
            
        }
           
        

        private void lstBikes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstBikes.SelectedIndex < 0)
                return;

            var bikes = listOfBikes[lstBikes.SelectedIndex];
            if (bikes is RoadBikes)
            {
                cbBikeType.SelectedIndex = 0;
                var bikesAsRegular = (RoadBikes)bikes;
                cbTireType.SelectedIndex = (int)bikesAsRegular.TireType;
               
            }
            else
            {
                cbBikeType.SelectedIndex = 1;
                var bikeAsMountain = (MountainBikes)bikes;
                cbSuspensionType.SelectedIndex = (int)bikeAsMountain.SuspensionType;
            }
               

                txtSerialNumber.Text = bikes.Serialnumber.ToString();
            txtOriginalId.Text = txtSerialNumber.Text;
           
            txtModel.Text = bikes.Model;
            txtManufacturingyear.Text = bikes.Manufacturingyear.ToString();
            cbColor.SelectedIndex = (int)bikes.Color;
            
           
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            BikesXmlData.Save(listOfBikes);

            MessageBox.Show("The list of bikes has been saved");
        }

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBikeType.Text == "Road")
            {
                cbSuspensionType.Enabled = false;
                cbTireType.Enabled = true;
                cbSuspensionType.SelectedIndex = -1;
                cbTireType.SelectedIndex = 0;
            }
            else
            {
                cbSuspensionType.Enabled = true;
                cbTireType.Enabled = false;
                cbSuspensionType.SelectedIndex = 0;
                cbTireType.SelectedIndex = -1;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to exit?",
                                         "Confirmation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
                return;
            else if (txtSerialNumber.Text != txtOriginalId.Text)
            {
                if (!Validator.ValidateUniqueId(txtSerialNumber.Text, listOfBikes))
                {
                    MessageBox.Show("This Serial Number is already used");
                    return;
                }
            }



            var bikesToUpdate = FindBikesById(Convert.ToInt32(txtOriginalId.Text));

            if (bikesToUpdate is RoadBikes && cbBikeType.Text == "Mountain" ||
                bikesToUpdate is MountainBikes && cbBikeType.Text == "Road")
            {
                MessageBox.Show("It is not possible to change the type. Alternatively, " +
                                "you may remove and add this bike with a different type");
                return;
            }

            if (cbBikeType.Text == "Road")
            {
                
                (bikesToUpdate as RoadBikes).TireType = (ETireType)Enum.Parse(typeof(ETireType), cbTireType.Text);
            }
            else
            {
                (bikesToUpdate as MountainBikes).SuspensionType = (ESuspensionType)Enum.Parse(typeof(ESuspensionType), cbSuspensionType.Text);

            }

            bikesToUpdate.Serialnumber = Convert.ToInt32(txtSerialNumber.Text);
            // bikesToUpdate.Name = txtName.Text;
            bikesToUpdate.Model = txtModel.Text;
            //  skateboardToUpdate.Weight = Convert.ToSingle(txtWeight.Text);
            bikesToUpdate.Manufacturingyear = Convert.ToInt32(txtManufacturingyear.Text);

            if (cbColor.Text == "Blue")
                bikesToUpdate.Color = EColor.Blue;
            else if (cbColor.Text == "Green")
                bikesToUpdate.Color = EColor.Green;
            else if (cbColor.Text == "Black")
                bikesToUpdate.Color = EColor.Black;
            else
                bikesToUpdate.Color = EColor.Red;
            //skateboardToUpdate.Color = (EColor)Enum.Parse(typeof(EColor), cbColor.Text);

            RefreshDisplayList();

            MessageBox.Show("The bikes has been updated");

        }

        private void rbAll_CheckedChanged_1(object sender, EventArgs e)
        {

            RefreshDisplayList();
            lstBikes.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void rbMountain_CheckedChanged_1(object sender, EventArgs e)
        {
            RefreshDisplayList();
            lstBikes.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void rbRoad_CheckedChanged_1(object sender, EventArgs e)
        {
            RefreshDisplayList();
            lstBikes.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSerialNumber.Text == "" || !Validator.ValidateId(txtSerialNumber.Text))
            {
                MessageBox.Show("Id is required and should be numeric");
                return;
            }

            int serialnumber = Convert.ToInt32(txtSerialNumber.Text);
            var bikesFound = FindBikesById(serialnumber);

            if (bikesFound == null)
            {
                MessageBox.Show("Bike not found");
                return;
            }

            string message = bikesFound.ToString().Replace(",", Environment.NewLine);
            MessageBox.Show(message);
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            int index = lstBikes.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a bike");
                return;
            }

            var result = MessageBox.Show("Do you really want to remove?",
                                         "Confirmation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            listOfBikes.RemoveAt(index);
            lstBikes.Items.RemoveAt(index);
        }
    }
}
