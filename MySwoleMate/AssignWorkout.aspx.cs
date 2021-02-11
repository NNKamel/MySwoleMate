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
    public partial class AssignWorkout : System.Web.UI.Page
    {
        TraineeBLL tbll = new TraineeBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
        TraineeViewModel trainee;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                trainee = tbll.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));

                WorkoutBLL wbll = new WorkoutBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());

                List<WorkoutViewModel> workoutList = wbll.GetAllWorkouts();

                List<ListItem> items = new List<ListItem>();

                items.Add(new ListItem("--  Select an option  --", null));

                workoutList.ForEach(delegate (WorkoutViewModel workout)
                {
                    items.Add(new ListItem(
                        workout.DisplayExercise1
                        + " " + workout.DisplayExercise2
                        + " " + workout.DisplayExercise3
                        + " " + workout.DisplayExercise4
                        + " " + workout.DisplayExercise5, workout.WorkoutID.ToString()));
                });

                if (trainee.WorkoutID!=0)
                {
                    WorkoutDropdownList.SelectedValue = trainee.WorkoutID.ToString();
                }

                WorkoutDropdownList.DataSource = items;
                WorkoutDropdownList.DataValueField = "Value";
                WorkoutDropdownList.DataTextField = "Text";
                WorkoutDropdownList.DataBind();
            }
        }

        protected void AssignWorkout_OnClick(object sender, EventArgs e)
        {
            trainee = tbll.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));

            trainee.WorkoutID = Convert.ToInt32(WorkoutDropdownList.SelectedItem.Value);

            tbll.EditTrainee(trainee);

            Response.Redirect("~/Trainees.aspx");
        }
    }
}