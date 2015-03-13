using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace lprogram
{
    class Movements
    {
        int movementID;
        int coeff;
        int num;
        Boolean collective = false;

        public Movements()
        {
            movementID = 0;
            coeff = 1;
            num = 0;
            collective = false;
        }

        public Movements(int ID)
        {
            movementID = ID;
            collective  = false;
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable movement;
            string query = String.Format("select * from Movements where ID = {0}", movementID);
            movement = db.GetDataTable(query);
            if  (movement != null)
            {
                coeff = int.Parse(movement.Rows[0]["Coeff"].ToString());
                num = int.Parse(movement.Rows[0]["MovementNo"].ToString());
                if (int.Parse(movement.Rows[0]["Collective"].ToString()) == 1)
                    collective = true;
            }
        }

        public int getCoeff()
        {
            return coeff;
        }


    }
}
