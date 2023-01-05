using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void Car_Load_1(object sender, EventArgs e)
        {
          id.Text = ID.ToString();
          model.Enabled = false;
          year.Enabled = false;
          gear.Enabled = false;
          color.Enabled = false;
          speed.Enabled = false;
        }
        public DataTable car_list = new DataTable();
        public int ID = 1;
        private void customize_Click(object sender, EventArgs e)
        {

            if (mygrid.Columns.Contains(idBox.Text) && idBox.Checked == false) //ID CheckBox
            {
                MessageBox.Show("ID Column is required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    idBox.Checked = true;
                    return;
            }
            else
            {
                if (mygrid.Columns.Contains(idBox.Text) == false && idBox.Checked)
                    car_list.Columns.Add(idBox.Text);
            }

            if (mygrid.Columns.Contains(modelBox.Text) && modelBox.Checked == false) //Model CheckBox
            {
                if (MessageBox.Show("Do you want to remove the MODEL coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    model.Enabled = false;
                    car_list.Columns.Remove(modelBox.Text);
                }
                else
                {
                    modelBox.Checked = true;
                    return;
                }
            }
            else
            {
                if (mygrid.Columns.Contains(modelBox.Text) == false && modelBox.Checked)
                {
                    model.Enabled = true;
                    car_list.Columns.Add(modelBox.Text);
                }
            }

            if (mygrid.Columns.Contains(yearBox.Text) && yearBox.Checked == false) // Year CheckBox
            {
                if (MessageBox.Show("Do you want to remove the YEAR coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    year.Enabled = false;
                    car_list.Columns.Remove(yearBox.Text);
                }
                else
                {
                    yearBox.Checked = true;
                    return;
                }
            }
            else
            {
                if (mygrid.Columns.Contains(yearBox.Text) == false && yearBox.Checked)
                {
                    year.Enabled = true;
                    car_list.Columns.Add(yearBox.Text);
                }
            }

            if (mygrid.Columns.Contains(gearbox.Text) && gearbox.Checked == false) // GearBox checkBox 
            {
                if (MessageBox.Show("Do you want to remove the GEARBOX coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    gear.Enabled = false;
                    car_list.Columns.Remove(gearbox.Text);
                }
                else
                {
                    gearbox.Checked = true;
                    return;
                }
            }
            else
            {
                if (mygrid.Columns.Contains(gearbox.Text) == false && gearbox.Checked)
                {
                    gear.Enabled = true;
                    car_list.Columns.Add(gearbox.Text);
                }
            }

            if (mygrid.Columns.Contains(colorBox.Text) && colorBox.Checked == false) // Color checkBox
            {
                if (MessageBox.Show("Do you want to remove the COLOR coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    color.Enabled = false;
                    car_list.Columns.Remove(colorBox.Text);
                }
                else
                {
                    colorBox.Checked = true;
                    return;
                }
            }
            else
            {
                if (mygrid.Columns.Contains(colorBox.Text) == false && colorBox.Checked)
                {
                    color.Enabled = true;
                    car_list.Columns.Add(colorBox.Text);
                }
            }

            if (mygrid.Columns.Contains(maxBox.Text) && maxBox.Checked == false) // Max_Speed checkBox
            {
                if (MessageBox.Show("Do you want to remove the MAX_SPEED coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    speed.Enabled = false;
                    car_list.Columns.Remove(maxBox.Text);
                }
                else
                {
                    maxBox.Checked = true;
                    return;
                }
            }
            else
            {
                if (mygrid.Columns.Contains(maxBox.Text) == false && maxBox.Checked)
                {
                    speed.Enabled = true;
                    car_list.Columns.Add(maxBox.Text);
                }
            }

            mygrid.DataSource = car_list;
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (modelBox.Checked == false && yearBox.Checked == false && gearbox.Checked == false && colorBox.Checked == false &&
                maxBox.Checked == false) MessageBox.Show("Data Column Header is empty\nPlease select a column Header First!!");

            else
            {
                if (model.Text == "") errorProvider1.SetError(model, "Required Field");
                else
                {
                    car_list.Rows.Add(model.Text);
                    errorProvider1.Clear();
                }

                if (year.Text == "") errorProvider1.SetError(year, "Required Field");
                else
                {
                    car_list.Rows.Add(year.Text);
                    errorProvider1.Clear();
                }

                if (gear.Text == "") errorProvider1.SetError(gear, "Required Field");
                else
                {
                    car_list.Rows.Add(gear.Text);
                    errorProvider1.Clear();
                }

                if (color.Text == "") errorProvider1.SetError(color, "Required Field");
                else
                {
                    car_list.Rows.Add(color.Text);
                    errorProvider1.Clear();
                }

                if (speed.Text == "" && maxBox.Checked) errorProvider1.SetError(speed, "Required Field");
                else
                {
                    car_list.Rows.Add(speed.Text);
                    errorProvider1.Clear();
                }


                //if (model.Text == "" || year.Text == "" || gear.Text == "" || color.Text == "" || speed.Text == "")
                 //   MessageBox.Show("Please Fill Required Filleds", "NOTICE!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                car_list.Rows.Add(ID++);
                id.Text = ID.ToString();
            }

            mygrid.DataSource = car_list;
        }
    }
}
