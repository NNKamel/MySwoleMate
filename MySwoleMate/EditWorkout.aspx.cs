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
    public partial class EditWorkout : System.Web.UI.Page
    {
        WorkoutBLL bll = new WorkoutBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WorkoutViewModel workout = bll.GetWorkoutById(Convert.ToInt32(Request.QueryString["WorkoutID"]));

                Exercise1.Text = workout.Exercise1;
                Exercise1Reps.Text = workout.Exercise1Reps;
                Exercise1Sets.Text = workout.Exercise1Sets;

                Exercise2.Text = workout.Exercise2;
                Exercise2Reps.Text = workout.Exercise2Reps;
                Exercise2Sets.Text = workout.Exercise2Sets;

                Exercise3.Text = workout.Exercise3;
                Exercise3Reps.Text = workout.Exercise3Reps;
                Exercise3Sets.Text = workout.Exercise3Sets;

                Exercise4.Text = workout.Exercise4;
                Exercise4Reps.Text = workout.Exercise4Reps;
                Exercise4Sets.Text = workout.Exercise4Sets;

                Exercise5.Text = workout.Exercise5;
                Exercise5Reps.Text = workout.Exercise5Reps;
                Exercise5Sets.Text = workout.Exercise5Sets;


            }
        }

        protected void WorkoutEditButton_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                WorkoutViewModel workout = new WorkoutViewModel();

                workout.WorkoutID = Convert.ToInt32(Request.QueryString["WorkoutID"]);

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

                bll.EditWorkout(workout);
                Response.Redirect("~/Workouts.aspx");
            }
        }
    }
}