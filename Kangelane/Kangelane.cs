﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Kangelane
    {
        public string nimi { get; set; }
        public string asukoht { get; set; }

        public Kangelane(string _nimi, string _asukoht)
        {
            nimi = _nimi;
            asukoht = _asukoht;
        }

        public virtual int Paasta(int ohus)
        {
            return (int)(0.9 * ohus);
        }

        public virtual string Vormiriietus()
        {
            return "T-sarg, puksid, tavaliselt riietud...";
        }

        public virtual string Tervitus()
        {
            return "Chau! Olen tavaline kangelane...";
        }

        public virtual string MissiooniStaatus()
        {
            Random rand = new Random();
            int chance = rand.Next(0, 100);

            if (chance < 50)
            {
                return "olen valmis!";
            }
            else
            {
                return " aaaa! Olen hoivatud!";
            }
        }

        public override string ToString()
        {
            return $"""
        Kangelase andmed:
        Nimi: {nimi}
        Asukoht: {asukoht}
        Vormiriietus: {Vormiriietus()}
        Tervitus: {Tervitus()}
        Missiooni staatus: {MissiooniStaatus()}
        """;
        }
        public string Kirjelda(int ohus)
        {
            return $"""
        {ToString()}
        Inimesi ohus: {ohus}
        Päästab: {Paasta(ohus)}
        """;
        }
    }

