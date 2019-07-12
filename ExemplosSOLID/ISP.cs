namespace RuimISP
{
    interface IDesenvolvimentoTODOS
    {
        void Programar();
        void Testar();
    }

    class Desenvolvedores : IDesenvolvimentoTODOS
    {
        public void Programar()
        {
            // Programar e tomar café
        }

        public void Testar()
        {
            throw new System.NotImplementedException();
        }
    }

    class Testadores : IDesenvolvimentoTODOS
    {
        public void Programar()
        {
            throw new System.NotImplementedException();
        }

        public void Testar()
        {
            // Testar todos alterações
        }
    }
}

namespace BomISP
{
    interface IDesenvolvedoresTODOS
    {
        void Programar();
    }

    interface ITestadoresTODOS
    {
        void Testar();
    }

    class Desenvolvedores : IDesenvolvedoresTODOS
    {
        public void Programar()
        {
            // Programar e tomar café
        }
      
    }

    class Testadores : ITestadoresTODOS
    {
        public void Testar()
        {
            // Testar
        }
    }
}