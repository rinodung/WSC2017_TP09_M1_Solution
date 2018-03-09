using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2017_TP09_M2_Solution
{
    public partial class ManageFlightSchedule : Form
    {
        public ManageFlightSchedule()
        {
            InitializeComponent();
        }

        private void ManageFlightSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'session2DataSet.Aircrafts' table. You can move, or remove it, as needed.
            this.aircraftsTableAdapter.Fill(this.session2DataSet.Aircrafts);
            // TODO: This line of code loads data into the 'session2DataSet.Schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this.session2DataSet.Schedules);
            // TODO: This line of code loads data into the 'session2DataSet.Airports' table. You can move, or remove it, as needed.
            this.airportsTableAdapter.Fill(this.session2DataSet.Airports);

            session2Entities db = new session2Entities();
            
           this.bindingSource1.DataSource = db.Schedules.ToList();




        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.schedulesTableAdapter.FillBy(this.session2DataSet.Schedules);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditSchedule editScheduleForm = new EditSchedule();            
            editScheduleForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImportChange importChangeForm = new ImportChange();
            importChangeForm.Show();
        }
    }
}
