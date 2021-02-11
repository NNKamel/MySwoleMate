using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.DAL
{
    //DAL stands for Data Access Layer. Data Access Layer is the layer which communicates to the database.
    public class WorkoutDAL
    {
        private string _connectionString;

        public WorkoutDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<WorkoutViewModel> GetWorkouts()
        {
            string sqlQuery = "SELECT * FROM Workout";

            List<WorkoutViewModel> workouts = new List<WorkoutViewModel>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    WorkoutViewModel workout;
                    while (reader.Read())
                    {
                        workout = new WorkoutViewModel();
                        workout.WorkoutID = Convert.ToInt32(reader["WorkoutID"]);

                        workout.Exercise1 = reader["Exercise1"].ToString();
                        workout.Exercise1Reps = reader["Exercise1Reps"].ToString();
                        workout.Exercise1Sets = reader["Exercise1Sets"].ToString();

                        workout.Exercise2 = reader["Exercise2"].ToString();
                        workout.Exercise2Reps = reader["Exercise2Reps"].ToString();
                        workout.Exercise2Sets = reader["Exercise2Sets"].ToString();

                        workout.Exercise3 = reader["Exercise3"].ToString();
                        workout.Exercise3Reps = reader["Exercise3Reps"].ToString();
                        workout.Exercise3Sets = reader["Exercise3Sets"].ToString();

                        workout.Exercise4 = reader["Exercise4"].ToString();
                        workout.Exercise4Reps = reader["Exercise4Reps"].ToString();
                        workout.Exercise4Sets = reader["Exercise4Sets"].ToString();

                        workout.Exercise5 = reader["Exercise5"].ToString();
                        workout.Exercise5Reps = reader["Exercise5Reps"].ToString();
                        workout.Exercise5Sets = reader["Exercise5Sets"].ToString();

                        workouts.Add(workout);
                    }
                }
            }
            return workouts;
        }

        public WorkoutViewModel GetWorkoutById(int id)
        {
            WorkoutViewModel workout = new WorkoutViewModel();

            string sqlQuery = "SELECT * FROM Workout WHERE WorkoutID=@ID";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        workout.WorkoutID = Convert.ToInt32(reader["WorkoutID"]);

                        workout.Exercise1 = reader["Exercise1"].ToString();
                        workout.Exercise1Reps = reader["Exercise1Reps"].ToString();
                        workout.Exercise1Sets = reader["Exercise1Sets"].ToString();

                        workout.Exercise2 = reader["Exercise2"].ToString();
                        workout.Exercise2Reps = reader["Exercise2Reps"].ToString();
                        workout.Exercise2Sets = reader["Exercise2Sets"].ToString();

                        workout.Exercise3 = reader["Exercise3"].ToString();
                        workout.Exercise3Reps = reader["Exercise3Reps"].ToString();
                        workout.Exercise3Sets = reader["Exercise3Sets"].ToString();

                        workout.Exercise4 = reader["Exercise4"].ToString();
                        workout.Exercise4Reps = reader["Exercise4Reps"].ToString();
                        workout.Exercise4Sets = reader["Exercise4Sets"].ToString();

                        workout.Exercise5 = reader["Exercise5"].ToString();
                        workout.Exercise5Reps = reader["Exercise5Reps"].ToString();
                        workout.Exercise5Sets = reader["Exercise5Sets"].ToString();
                    }
                }
            }

            return workout;
        }

        public int EditWorkout(WorkoutViewModel newWorkout)
        {
            string sqlQuery = "UPDATE Workout SET "+
                "Exercise1=@Exercise1, "+
                "Exercise1Reps=@Exercise1Reps, "+
                "Exercise1Sets=@Exercise1Sets, " +
                "Exercise2=@Exercise2, " +
                "Exercise2Reps=@Exercise2Reps, " +
                "Exercise2Sets=@Exercise2Sets, " +
                "Exercise3=@Exercise3, " +
                "Exercise3Reps=@Exercise3Reps, " +
                "Exercise3Sets=@Exercise3Sets, " +
                "Exercise4=@Exercise4, " +
                "Exercise4Reps=@Exercise4Reps, " +
                "Exercise4Sets=@Exercise4Sets, " +
                "Exercise5=@Exercise5, " +
                "Exercise5Reps=@Exercise5Reps, " +
                "Exercise5Sets=@Exercise5Sets " +
                "WHERE WorkoutID=@WorkoutID";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@Exercise1", SqlDbType.VarChar).Value = newWorkout.Exercise1;
                cmd.Parameters.Add("@Exercise1Reps", SqlDbType.VarChar).Value = newWorkout.Exercise1Reps;
                cmd.Parameters.Add("@Exercise1Sets", SqlDbType.VarChar).Value = newWorkout.Exercise1Sets;

                cmd.Parameters.Add("@Exercise2", SqlDbType.VarChar).Value = newWorkout.Exercise2;
                cmd.Parameters.Add("@Exercise2Reps", SqlDbType.VarChar).Value = newWorkout.Exercise2Reps;
                cmd.Parameters.Add("@Exercise2Sets", SqlDbType.VarChar).Value = newWorkout.Exercise2Sets;

                cmd.Parameters.Add("@Exercise3", SqlDbType.VarChar).Value = newWorkout.Exercise3;
                cmd.Parameters.Add("@Exercise3Reps", SqlDbType.VarChar).Value = newWorkout.Exercise3Reps;
                cmd.Parameters.Add("@Exercise3Sets", SqlDbType.VarChar).Value = newWorkout.Exercise3Sets;

                cmd.Parameters.Add("@Exercise4", SqlDbType.VarChar).Value = newWorkout.Exercise4;
                cmd.Parameters.Add("@Exercise4Reps", SqlDbType.VarChar).Value = newWorkout.Exercise4Reps;
                cmd.Parameters.Add("@Exercise4Sets", SqlDbType.VarChar).Value = newWorkout.Exercise4Sets;

                cmd.Parameters.Add("@Exercise5", SqlDbType.VarChar).Value = newWorkout.Exercise5;
                cmd.Parameters.Add("@Exercise5Reps", SqlDbType.VarChar).Value = newWorkout.Exercise5Reps;
                cmd.Parameters.Add("@Exercise5Sets", SqlDbType.VarChar).Value = newWorkout.Exercise5Sets;

                cmd.Parameters.Add("@WorkoutID", SqlDbType.Int).Value = newWorkout.WorkoutID;

                return cmd.ExecuteNonQuery();
            }
        }

        public int AddWorkout(WorkoutViewModel newWorkout)
        {
            string sqlQuery = "INSERT INTO Workout ("
                + "Exercise1, Exercise1Reps, Exercise1Sets,"
                + "Exercise2, Exercise2Reps, Exercise2Sets,"
                + "Exercise3, Exercise3Reps, Exercise3Sets,"
                + "Exercise4, Exercise4Reps, Exercise4Sets,"
                + "Exercise5, Exercise5Reps, Exercise5Sets"
                + ") VALUES ("
                + "@Exercise1, @Exercise1Reps, @Exercise1Sets,"
                + "@Exercise2, @Exercise2Reps, @Exercise2Sets,"
                + "@Exercise3, @Exercise3Reps, @Exercise3Sets,"
                + "@Exercise4, @Exercise4Reps, @Exercise4Sets,"
                + "@Exercise5, @Exercise5Reps, @Exercise5Sets"
                + ")";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@Exercise1", SqlDbType.VarChar).Value = newWorkout.Exercise1;
                cmd.Parameters.Add("@Exercise1Reps", SqlDbType.VarChar).Value = newWorkout.Exercise1Reps;
                cmd.Parameters.Add("@Exercise1Sets", SqlDbType.VarChar).Value = newWorkout.Exercise1Sets;

                cmd.Parameters.Add("@Exercise2", SqlDbType.VarChar).Value = newWorkout.Exercise2;
                cmd.Parameters.Add("@Exercise2Reps", SqlDbType.VarChar).Value = newWorkout.Exercise2Reps;
                cmd.Parameters.Add("@Exercise2Sets", SqlDbType.VarChar).Value = newWorkout.Exercise2Sets;

                cmd.Parameters.Add("@Exercise3", SqlDbType.VarChar).Value = newWorkout.Exercise3;
                cmd.Parameters.Add("@Exercise3Reps", SqlDbType.VarChar).Value = newWorkout.Exercise3Reps;
                cmd.Parameters.Add("@Exercise3Sets", SqlDbType.VarChar).Value = newWorkout.Exercise3Sets;

                cmd.Parameters.Add("@Exercise4", SqlDbType.VarChar).Value = newWorkout.Exercise4;
                cmd.Parameters.Add("@Exercise4Reps", SqlDbType.VarChar).Value = newWorkout.Exercise4Reps;
                cmd.Parameters.Add("@Exercise4Sets", SqlDbType.VarChar).Value = newWorkout.Exercise4Sets;

                cmd.Parameters.Add("@Exercise5", SqlDbType.VarChar).Value = newWorkout.Exercise5;
                cmd.Parameters.Add("@Exercise5Reps", SqlDbType.VarChar).Value = newWorkout.Exercise5Reps;
                cmd.Parameters.Add("@Exercise5Sets", SqlDbType.VarChar).Value = newWorkout.Exercise5Sets;
                return cmd.ExecuteNonQuery();
            }
        }

        public int DeleteWorkout(int id)
        {
            string sqlQuery = "DELETE FROM Workout WHERE WorkoutID=@ID";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
