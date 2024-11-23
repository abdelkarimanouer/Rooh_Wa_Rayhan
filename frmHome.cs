using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace روح_وريحان
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("روح وريحان هو تطبيق مميز يقدم خدمات دينية شاملة للمسلمين." +
                " يتضمن التطبيق القرآن الكريم بالإضافة إلى الأذكار والأدعية،" +
                " ويوفر أيضًا ميزة تنبيهات لأوقات الصلاة. يمكن للمستخدمين تصفح القرآن بسهولة والاستماع إليه،" +
                " كما يتيح التطبيق إمكانية تخصيص تجربة الاستماع والتصفح حسب تفضيلاتهم الشخصية." +
                " يُعتبر روح وريحان أداة قيمة للمساعدة في تعزيز التواصل مع الله وتعزيز الروحانية في حياة المستخدمين"
               
                , "حول التطبيق", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
