using MVVMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlena
{
    public class WizardController : Controller
    {
        private FormModel _model;

        public override void Initial()
        {
            StartPage();
        }

        private void StartPage()
        {
            ExecuteNavigation();
        }
    }
}
