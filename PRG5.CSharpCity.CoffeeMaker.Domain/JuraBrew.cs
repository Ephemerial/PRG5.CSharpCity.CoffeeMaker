using System;
using System.Collections.Generic;

namespace PRG5.CSharpCity.CoffeeMaker.Domain
{
    public enum BrewType
    {
        Koffie,
        Cappucino,
        Espresso,
        Ristretto
    }

    public class JuraBrew
    {
        private List<BrewType> _bakjesLijst;

        private int _aantalBakjes;
        private BrewType _soortKoffie;

        public BrewType SoortKoffie
        {
            get
            {
                return _soortKoffie;
            }
            set
            {
                _soortKoffie = value;
            }
        }

        public JuraBrew()
        {
            _bakjesLijst = new List<BrewType>();
            _aantalBakjes = 0;
            SoortKoffie = BrewType.Koffie;
        }

        public int AantalBakjes
        {
            get
            {
                return _aantalBakjes;
            }
        }

        public List<BrewType> BakjesLijst
        {
            get { return _bakjesLijst; }
        }

        public bool Ontkalken()
        {
            if (_aantalBakjes > 5)
            {
                _aantalBakjes = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Brew()
        {
            if (_aantalBakjes > 5)
            {
                return "U moet eerst ontkalken";
            }
            else
            {
                _bakjesLijst.Add(this._soortKoffie);
                _aantalBakjes++;
                return "Lekker bakkie :" + this.SoortKoffie.ToString();
            }
        }
    }
}
