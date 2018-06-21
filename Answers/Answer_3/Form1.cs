using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Answer_3.Models;
namespace Answer_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void defineBtn_Click(object sender, EventArgs e)
        {
            
            DiagnosisDbEntities diagnosisDbEntities = new DiagnosisDbEntities();
            foreach (string item in checkBoxList.CheckedItems)
            {
               
            }
            var tagIds = new int[] { 1, 2,3,4,5};

            var query= from illness in diagnosisDbEntities.Illnesses
                        from symptom in illness.Symptoms
                        where tagIds.Contains(symptom.Id)
                        select symptom.Id;
//           SELECT* FROM IllnessSymptom ilssym
//INNER JOIN Illnesses ill ON ilssym.Illnesses_id = ill.id
//WHERE ilssym.Symptoms_Id IN(2,3,4)
            dataGridView1.DataSource = query.ToList();

        }
    }
}
