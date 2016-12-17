using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Eval.Web.EvalServiceReference;

namespace Eval.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Eval_Orchestrations_ProcessEvals_EvalServiceClient proxy = new Eval_Orchestrations_ProcessEvals_EvalServiceClient();
            Evaluation eval = new Evaluation();
            eval.Student = txtName.Text;
            eval.TrainingCourse = dlCourse.SelectedValue;
            eval.Rating=dlRating.SelectedValue;
            var result = proxy.SubmitEval(eval);
            txtResponseText.Text = result.Message;
            btnSubmit.Enabled = false;
        }



    }
}