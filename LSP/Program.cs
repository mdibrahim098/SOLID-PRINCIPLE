

using System.Reflection.Metadata.Ecma335;

namespace OCP
{

    public interface ITraining
    {
        int GetTraining();
    }
    public interface IMambership : ITraining
    {
        public void Add();

    }
    public class Membership : IMambership
    {
        public virtual void Add()
        {
            Console.WriteLine("Membership added.");
        }

        public virtual int GetTraining()
        {
            return 2;
        }
    }



    public class PlusMembership : Membership
    {
        public override int GetTraining()
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


    //public class TrialMembership : Membership
    //{
    //    public override void Add()
    //    {
    //        throw new NotImplementedException("Trial membership does not support adding members.");
    //    }
    //    public override int GetTraining()
    //    {
    //        return 2;
    //    }
    //}

    public class TrialMembership : ITraining
    {
        public int GetTraining()
        {
            return 2;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            List<Membership> memberships = new List<Membership>();
            memberships.Add(new PlusMembership());
            memberships.Add(new ProMembership());
           // memberships.Add(new TrialMembership());

            foreach (var item in memberships)
            {
                item.Add();
            }
        }
    }

}