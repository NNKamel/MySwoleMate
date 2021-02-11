using MySwoleMate.BLL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySwoleMate
{
    public partial class AddWorkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void WorkoutAddButton_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();

                WorkoutBLL bll = new WorkoutBLL(connectionString);

                WorkoutViewModel workout = new WorkoutViewModel();
                workout.Exercise1 = Exercise1.Text;
                workout.Exercise1Reps = Exercise1Reps.Text;
                workout.Exercise1Sets = Exercise1Sets.Text;

                workout.Exercise2 = Exercise2.Text;
                workout.Exercise2Reps = Exercise2Reps.Text;
                workout.Exercise2Sets = Exercise2Sets.Text;

                workout.Exercise3 = Exercise3.Text;
                workout.Exercise3Reps = Exercise3Reps.Text;
                workout.Exercise3Sets = Exercise3Sets.Text;

                workout.Exercise4 = Exercise4.Text;
                workout.Exercise4Reps = Exercise4Reps.Text;
                workout.Exercise4Sets = Exercise4Sets.Text;

                workout.Exercise5 = Exercise5.Text;
                workout.Exercise5Reps = Exercise5Reps.Text;
                workout.Exercise5Sets = Exercise5Sets.Text;

                bll.AddWorkout(workout);
                Response.Redirect("~/Workouts.aspx");
            }
        }
    }
}