using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        } 

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Dima", LastName = "Kavetskyy" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Faisal", LastName = "Pupu" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Heyo" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });


        }

        private void WireUpLists()
        {
            selectteamdrop.DataSource = availableTeamMembers;
            selectteamdrop.DisplayMember = "FullName";

            teammembersListBox.DataSource = selectedTeamMembers;

        }
        private void selectteamdrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectteamlmemberlabel_Click(object sender, EventArgs e)
        {
            
        }

        private void creatememberlabel_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstnamevalue.Text;
                p.LastName = lastnamevalue.Text;
                p.EmailAdress = emailvalue.Text;
                p.CellphoneNumber = cellphonevalue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstnamevalue.Text = "";
                lastnamevalue.Text = "";
                emailvalue.Text = "";
                cellphonevalue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private void createTournlabel_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            if(firstnamevalue.Text.Length == 0)
            {
                return false;
            }

            if (lastnamevalue.Text.Length == 0)
            {
                return false;
            }

            if (emailvalue.Text.Length == 0)
            {
                return false;
            }

            if (cellphonevalue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void Addmemberlabel_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectteamdrop.SelectedItem;

            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);
        }
    }
}
