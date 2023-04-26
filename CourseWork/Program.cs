namespace CourseWork
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new DataBaseContext())
            {

            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InformationForm informationForm = new InformationForm();
            informationForm.ShowDialog();

            ParticipantForm participantForm = new ParticipantForm();
            PoemForm poemForm = new PoemForm();
            CompetitionForm competitionForm = new CompetitionForm();
            StatisticsForm statisticsForm = new StatisticsForm();

            List<Form> forms = new List<Form>();
            forms.Add(participantForm);
            forms.Add(poemForm);
            forms.Add(competitionForm);
            forms.Add(statisticsForm);

            participantForm.Add_Forms_List(forms);
            poemForm.Add_Forms_List(forms);
            competitionForm.Add_Forms_List(forms);
            statisticsForm.Add_Forms_List(forms);

            NavigationForm navigationForm = new NavigationForm();
            navigationForm.Add_Forms_List(forms);
            Application.Run(navigationForm);

        }
    }
}