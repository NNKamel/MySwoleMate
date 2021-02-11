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
    public partial class ViewWorkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();

                TraineeBLL tbll = new TraineeBLL(connectionString);
                TraineeViewModel trainee = tbll.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));
                MainTitle.Text = "Workout Assigned to " + trainee.FirstName + " " + trainee.LastName;

                WorkoutBLL bll = new WorkoutBLL(connectionString);
                //int workoutID = Convert.ToInt32(Request.QueryString["WorkoutID"]);
                int workoutID = trainee.WorkoutID;


                if (workoutID != 0)
                {
                    WorkoutViewModel workout = bll.GetWorkoutById(workoutID);
                    Exercise1.Text = workout.DisplayExercise1;
                    Exercise2.Text = workout.DisplayExercise2;
                    Exercise3.Text = workout.DisplayExercise3;
                    Exercise4.Text = workout.DisplayExercise4;
                    Exercise5.Text = workout.DisplayExercise5;
                }
                else
                {
                    Exercise1.Text = "No workout assigned";
                }

            }

        }

        protected void Button_OnClickAssignWorkout(object sender, EventArgs e)
        {
            int traineeID = Convert.ToInt32(Request.QueryString["TraineeID"]);
            Response.Redirect("~/AssignWorkout.aspx?TraineeID=" + traineeID);
        }
    }
}