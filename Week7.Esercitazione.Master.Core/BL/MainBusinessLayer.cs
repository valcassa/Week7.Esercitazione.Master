namespace Week7.Esercitazione.Master
{
    public class MainBusinessLayer
    {
        private RepositoryProdottiEF repositoryProdottiEF;

        public MainBusinessLayer(RepositoryProdottiEF repositoryProdottiEF)
        {
            this.repositoryProdottiEF = repositoryProdottiEF;
        }
    }
}