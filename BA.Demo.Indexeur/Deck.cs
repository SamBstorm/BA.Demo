using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.Indexeur
{
    public class Deck
    {
        private List<Carte> _mainDeck = new List<Carte>();
        
        public Carte this[int index]
        {
            get {
                Carte c = null;
                if (index < _mainDeck.Count - 1 && index >= 0)
                {
                    c = _mainDeck[index];
                    _mainDeck.Remove(c);
                }
                return c;
            }
            set {
                if (index >= 0 && index < _mainDeck.Count - 1)
                {
                    _mainDeck[index] = value;
                }
                else
                {
                    _mainDeck.Add(value);
                }
            }
        }

        public Carte this[Couleurs col, Valeurs val]
        {
            get
            {
                Carte c = null;
                for (int i = 0; i < _mainDeck.Count; i++)
                {
                    if (_mainDeck[i].Couleur == col && _mainDeck[i].Valeur == val)
                    {
                        c = _mainDeck[i];
                        _mainDeck.Remove(c);
                    }
                }
                return c;
            }
            set
            {
                Carte c = null;
                foreach (Carte carte in _mainDeck)
                {
                    if (carte.Couleur == col && carte.Valeur == val) c = carte;
                }
                if(c is null)
                {
                    _mainDeck.Add(new Carte() { Couleur = col, Valeur = val });
                }
            }
        }

        public void InitDeck()
        {
            foreach (string colorName in Enum.GetNames(typeof(Couleurs)))
            {
                Couleurs col = Enum.Parse<Couleurs>(colorName);
                foreach (string valueName in Enum.GetNames(typeof(Valeurs)))
                {
                    Carte c = new Carte();
                    c.Couleur = col;
                    c.Valeur = Enum.Parse<Valeurs>(valueName);
                    _mainDeck.Add(c);
                }
            }
        }
    }
}
