namespace CCSA{
    public class CCSAclass
    {
        static void Main()
        {
            Human[] humans=new Human[10];

            for (int i = 0; i < humans.Length; i++)
            {
                if (i < 5)
                {
                    BackEnd cohorts = new BackEnd("monday");
                    BackEnd cohorts2 = new BackEnd("wednesday");
                }
                else
                {
                    FrontEnd cohorts = new FrontEnd("monday");
                    FrontEnd cohorts2 = new FrontEnd("wednesday");

                }
            }

        }
    }
}