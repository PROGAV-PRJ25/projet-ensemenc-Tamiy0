public class Plante
{
    Random rnd = new Random();
    public string Type { get; set; }
    public int EsperanceDeVie {get; set;}
    public int PlantePositionX { get; set; }
    public int PlantePositionY { get; set; }
    public int TauxCroissance {get; set; }

    public int cycleStep = 0;
    private string[] EtatPlante = new string[] { ".", "p", "p", "P", "P", "R" };
    public string Affichage => EtatPlante[cycleStep];

    public Plante(string type, int x, int y, int tauxCroissance, int esperanceDeVie)
    {
        Type = type;
        PlantePositionX = x;
        PlantePositionY = y;
        TauxCroissance = tauxCroissance;
        EsperanceDeVie = esperanceDeVie;
    }

    public void MetAJour()
    {
        int essaiMAJ = rnd.Next(1,101);
        if ((essaiMAJ <= TauxCroissance) && (cycleStep < EtatPlante.Length - 1 ))
        {
            cycleStep = (cycleStep + 1) ;
        }
        EsperanceDeVie--;        
    }
}
