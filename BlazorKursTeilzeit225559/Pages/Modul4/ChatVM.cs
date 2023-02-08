namespace BlazorKursTeilzeit225559.Pages.Modul4
{
    public class ChatVM
    {
        public Action OnAdd;
        public List<NachrichtenModell> NachrichtenListe { get; set; } = new List<NachrichtenModell>();

        public void Add(string msg)
        {
            NachrichtenListe.Add(new NachrichtenModell() { Nachricht = msg });
            OnAdd?.Invoke();
        }
    }
}
