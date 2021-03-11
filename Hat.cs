using System;
using System.Collections.Generic;

namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }

        public string ShininessDescription()
        {
            /*  .this = this object, you can make multiple objects with a class
                when you say this, that specific time you used that object
                Think 2 hats with CLASS Hat, Hat1 and Hat2
                Hat2.ShininessDescription - referring to Hat2 itself 
            */

            if (this.ShininessLevel < 2)
            {
                return "dull";
            }
            else if (this.ShininessLevel <)
        }
    }

}