
{
    public interface ITimePerson
    {
        string Name { get; }

        string Surname { get; }


        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(int grade);

        //void AddGrade(char grade);

        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();

    }
}