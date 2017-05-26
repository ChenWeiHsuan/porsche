using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 訂便當系統.Model;

namespace 訂便當系統
{
    public class BaseForm : Form
    {
        public OrderDB db;
        public BaseForm()
        {
            db = new OrderDB();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }

   
}
