using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_calculator
{
    class Support
    {
        private static String[] grades = {"A+","A","A-","B+","B","B-","C+","C","C-","D" };
        private static double[] gradepoints = {4.2, 4, 3.7, 3.3, 3.0, 2.7, 2.3, 2.0, 1.5, 1 };
        private static ArrayList moduleArray = new ArrayList();
        private static ArrayList modueCreditsArray = new ArrayList();


        public static void addModule(String module, double moduleCredits)
        {
            moduleArray.Add(module);
            modueCreditsArray.Add(moduleCredits);

        }
        
        public static double getGradePoint(String grade)
        { 
            if (grades.Contains(grade)) return gradepoints[Array.IndexOf(grades, grade)];
            else return 0;
        }
      

    }
}
