using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.Models
{
    public class WorkoutViewModel
    {
        public int WorkoutID { get; set; }
        public string Exercise1 { get; set; }
        public string Exercise1Reps { get; set; }
        public string Exercise1Sets { get; set; }
        public string Exercise2 { get; set; }
        public string Exercise2Reps { get; set; }
        public string Exercise2Sets { get; set; }
        public string Exercise3 { get; set; }
        public string Exercise3Reps { get; set; }
        public string Exercise3Sets { get; set; }
        public string Exercise4 { get; set; }
        public string Exercise4Reps { get; set; }
        public string Exercise4Sets { get; set; }
        public string Exercise5 { get; set; }
        public string Exercise5Reps { get; set; }
        public string Exercise5Sets { get; set; }

        //ExerciseName: Sets x Reps
        public string DisplayExercise1 {
            get
            {
                return Exercise1 + ": " + Exercise1Sets + " x " + Exercise1Reps;
            }
        }
        public string DisplayExercise2
        {
            get
            {
                return Exercise2 + ": " + Exercise2Sets + " x " + Exercise2Reps;
            }
        }
        public string DisplayExercise3
        {
            get
            {
                return Exercise3 + ": " + Exercise3Sets + " x " + Exercise3Reps;
            }
        }
        public string DisplayExercise4
        {
            get
            {
                return Exercise4 + ": " + Exercise4Sets + " x " + Exercise4Reps;
            }
        }
        public string DisplayExercise5
        {
            get
            {
                return Exercise5 + ": " + Exercise5Sets + " x " + Exercise5Reps;
            }
        }
    }
}
