using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                ViewState.Add("Assets", assets);
                double[] elections = new double[0];
                ViewState.Add("Elections", elections);
                double[] acts = new double[0];
                ViewState.Add("Acts", acts);
                
            }

        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            //Get previous data from ViewState to variable, and resize variable(length +1)
            string[] assets = (string[])ViewState["Assets"];
            Array.Resize(ref assets, assets.Length + 1);
            double[] elections = (double[])ViewState["Elections"];
            Array.Resize(ref elections, elections.Length + 1);
            double[] acts = (double[])ViewState["Acts"];
            Array.Resize(ref acts, acts.Length + 1);

            //Get input data from TextBoxes
            assets[assets.GetUpperBound(0)] = assetNameTextBox.Text;
            elections[elections.GetUpperBound(0)] = double.Parse(electionsTextBox.Text);
            acts[acts.GetUpperBound(0)] = double.Parse(actsSubterfugeTextBox.Text);

            //To overwrite ViewState
            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;

            // To make label
            resultLabel.Text = String.Format(
                "Total Elections Rigged: {0}<br />" +
                "Average Acts of Subterfuge per Asset: {1:N2}<br />" +
                "(Last Asset you Added: {2})<br />",
                elections.Sum(),
                acts.Average(),
                assets[assets.GetUpperBound(0)]
                );

            // To make TextBoxes blank
            assetNameTextBox.Text = "";
            electionsTextBox.Text = "";
            actsSubterfugeTextBox.Text = "";

            // For validate
            /*
            resultLabel.Text += assets.Length + "<br />";


            for (int i=0; i<assets.Length; i++)
            {
                resultLabel.Text += assets[i] + " ";
            }
            */

        }
    }
}