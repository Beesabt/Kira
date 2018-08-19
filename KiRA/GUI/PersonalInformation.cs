﻿using System;
using System.Windows.Forms;
using KiRA.BusinessLogicLayer;
using KiRA.ValueObjects;

namespace KiRA.GUI
{
    public partial class PersonalInformation : UserControl
    {

        Settings _settings;
        Person _person;

        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void tlpPersonalInformation_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                _settings = new Settings();
                _person = new Person();

                _person = _settings.GetPersonalInformation();

                if(!string.IsNullOrEmpty(_person.Name)) { lNameFromDatabase.Text = _person.Name; }
                lRegisterNumberFromDatabase.Text = _person.RegisterNumber.ToString();
                if (!string.IsNullOrEmpty(_person.Company)) { lCompanyFromDatabase.Text = _person.Company; }
                if (!string.IsNullOrEmpty(_person.CostCenter)) { lCostCenterFromDatabase.Text = _person.CostCenter; }
                if (!string.IsNullOrEmpty(_person.Position)) { lPositionFromDatabase.Text = _person.Position; }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\r\n\r\n" + error.GetBaseException().ToString(), error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\r\n\r\n" + error.GetBaseException().ToString(), error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
