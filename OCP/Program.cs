

using System.Reflection.Metadata.Ecma335;

namespace OCP
{
    public class Membership
    {
        public int MemberShipType { get; set; }
        public void add()
        {
            //TO DO
        }
        public virtual int GetTraining()
        {
            return 2;
            //if(MemberShipType == 1) //plus 
            //{
            //    return 5;
            //}else if(MemberShipType == 2) // pro
            //{
            //    return 10;
            //}
            //else if (MemberShipType == 3) // premium
            //{
            //    return 20;
            //}
            //else
            //{
            //    return 2;
            //}
        }

    }

    public class PlusMembership : Membership
    {
       public  override int GetTraining()
        {
            return 5;
        }

    }

    public class ProMembership : Membership
    {
        public override int GetTraining()
        {
            return 10;
        }

    }


    class Program
    {
        public static void Main(string[] args)
        {

        }

    }

}