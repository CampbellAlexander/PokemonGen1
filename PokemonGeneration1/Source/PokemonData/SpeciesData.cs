﻿namespace PokemonGeneration1.Source.PokemonData
{
    public static class SpeciesData
    {

        public static readonly string[] Names = new string[]
        {
            "Null",
            "Bulbasaur", // 1
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie", //10
            "Metapod",
            "Butterfree",
            "Weedle",
            "Kakuna",
            "Beedrill",
            "Pidgey",
            "Pidgeotto",
            "Pidgeot",
            "Rattata",
            "Raticate", //20
            "Spearow",
            "Fearow",
            "Ekans",
            "Arbok",
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash",
            "Nidoran Female",
            "Nidorina",  //30
            "Nidoqueen",
            "Nidoran Male",
            "Nidorino",
            "Nidoking",
            "Clefairy",
            "Clefable",
            "Vulpix",
            "Ninetails",
            "Jigglypuff",
            "Wigglytuff", //40
            "Zubat",
            "Golbat",
            "Oddish",
            "Gloom",
            "Vileplume",
            "Paras",
            "Parasect",
            "Venonat",
            "Venomoth",
            "Diglett",
            "Dugtrio",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Abra",
            "Kadabra",
            "Alakazam",
            "Machop",
            "Machoke",
            "Machamp",
            "Bellsprout",
            "Weepinbell",
            "Victreebel",
            "Tentacool",
            "Tentacruel",
            "Geodude",
            "Graveler",
            "Golem",
            "Ponyta",
            "Rapidash",
            "Slowpoke",
            "Slowbro",
            "Magnemite",
            "Magneton",
            "Farfetch'd",
            "Doduo",
            "Dodrio",
            "Seel",
            "Dewgong",
            "Grimer",
            "Muk",
            "Shellder",
            "Cloyster",
            "Gastly",
            "Haunter",
            "Gengar",
            "Onix",
            "Drowzee",
            "Hypno",
            "Krabby",
            "Kingler",
            "Voltorb",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Cubone",
            "Marowak",
            "Hitmonlee",
            "Hitmonchan",
            "Lickitung",
            "Koffing",
            "Weezing",
            "Rhyhorn",
            "Rhydon",
            "Chansey",
            "Tangela",
            "Kangaskhan",
            "Horsea",
            "Seadra",
            "Goldeen",
            "Seaking",
            "Staryu",
            "Starmie",
            "Mr. Mime",
            "Scyther",
            "Jynx",
            "Electabuzz",
            "Magmar",
            "Pinsir",
            "Tauros",
            "Magikarp",
            "Gyarados",
            "Lapras",
            "Ditto",
            "Eevee",
            "Vaporeon",
            "Jolteon",
            "Flareon",
            "Porygon",
            "Omanyte",
            "Omastar",
            "Kabuto",
            "Kabutops",
            "Aerodactyl",
            "Snorlax",
            "Articuno",
            "Zapdos",
            "Moltres",
            "Dratini",
            "Dragonair",
            "Dragonite",
            "Mewtwo",
            "Mew"
        };





        public static readonly Type[][] Types = new Type[][]
        {
            //0 - No Pokemon
            new Type[] { Type.Null, Type.Null },
            //1 - Bulbasaur                      
            new Type[] { Type.Grass, Type.Poison },
            //2 - Ivysaur
            new Type[] { Type.Grass, Type.Poison },
            //3 - Venusaur
            new Type[] { Type.Grass, Type.Poison },
            //4 - Charmander
            new Type[] { Type.Fire, Type.Null },
            //5 - Charmeleon
            new Type[] { Type.Fire, Type.Null },
            //6 - Charizard
            new Type[] { Type.Fire, Type.Flying },
            //7 - Squirtle
            new Type[] { Type.Water, Type.Null },
            //8 - Wartortle
            new Type[] { Type.Water, Type.Null },
            //9 - Blastoise
            new Type[] { Type.Water, Type.Null },
            //10 - Caterpie
            new Type[] { Type.Bug, Type.Null },
            //11 - Metapod
            new Type[] { Type.Bug, Type.Null },
            //12 - Butterfree
            new Type[] { Type.Bug, Type.Flying },
            //13 - Weedle
            new Type[] { Type.Bug, Type.Poison },
            //14 - Kakuna
            new Type[] { Type.Bug, Type.Poison },
            //15 - Beedrill
            new Type[] { Type.Bug, Type.Poison },
            //16 - Pidgey
            new Type[] { Type.Normal, Type.Flying },
            //17 - Pidgeotto
            new Type[] { Type.Normal, Type.Flying },
            //18 - Pidgeot
            new Type[] { Type.Normal, Type.Flying },
            //19 - Rattata
            new Type[] { Type.Normal, Type.Null },
            //20 - Raticate
            new Type[] { Type.Normal, Type.Null },
            //21 - Spearow
            new Type[] { Type.Normal, Type.Flying },
            //22 - Fearow
            new Type[] { Type.Normal, Type.Flying },
            //23 - Ekans
            new Type[] { Type.Poison, Type.Null },
            //24 - Arbok
            new Type[] { Type.Poison, Type.Null },
            //25 - Pikachu
            new Type[] { Type.Electric, Type.Null },
            //26 - Raichu
            new Type[] { Type.Electric, Type.Null },
            //27 - Sandshrew
            new Type[] { Type.Ground, Type.Null },
            //28 - Sandslash
            new Type[] { Type.Ground, Type.Null },
            //29 - Nidoran Female
            new Type[] { Type.Poison, Type.Null },
            //30 - Nidorina
            new Type[] { Type.Poison, Type.Null },
            //31 - Nidoqueen
            new Type[] { Type.Poison, Type.Ground },
            //32 - Nidoran Male
            new Type[] { Type.Poison, Type.Null },
            //33 - Nidorino
            new Type[] { Type.Poison, Type.Null },
            //34 - Nidoking
            new Type[] { Type.Poison, Type.Ground },
            //35 - Clefairy
            new Type[] { Type.Normal, Type.Null },
            //36 - Clefable
            new Type[] { Type.Normal, Type.Null },
            //37 - Vulpix
            new Type[] { Type.Fire, Type.Null },
            //38 - Ninetails
            new Type[] { Type.Fire, Type.Null },
            //39 - Jigglypuff
            new Type[] { Type.Normal, Type.Null },
            //40 - Wigglytuff
            new Type[] { Type.Normal, Type.Null },
            //41 - Zubat
            new Type[] { Type.Poison, Type.Flying },
            //42 - Golbat
            new Type[] { Type.Poison, Type.Flying },
            //43 - Oddish
            new Type[] { Type.Grass, Type.Poison },
            //44 - Gloom
            new Type[] { Type.Grass, Type.Poison },
            //45 - Vileplume
            new Type[] { Type.Grass, Type.Poison },
            //46 - Paras
            new Type[] { Type.Bug, Type.Grass },
            //47 - Parasect
            new Type[] { Type.Bug, Type.Grass },
            //48 - Venonat
            new Type[] { Type.Bug, Type.Poison },
            //49 - Venomoth
            new Type[] { Type.Bug, Type.Poison },
            //50 - Diglett
            new Type[] { Type.Ground, Type.Null },
            //51 - Dugtrio
            new Type[] { Type.Ground, Type.Null },
            //52 - Meowth
            new Type[] { Type.Normal, Type.Null },
            //53 - Persian
            new Type[] { Type.Normal, Type.Null },
            //54 - Psyduck
            new Type[] { Type.Water, Type.Null },
            //55 - Golduck
            new Type[] { Type.Water, Type.Null },
            //56 - Mankey
            new Type[] { Type.Fighting, Type.Null },
            //57 - Primeape
            new Type[] { Type.Fighting, Type.Null },
            //58 - Growlithe
            new Type[] { Type.Fire, Type.Null },
            //59 - Arcanine
            new Type[] { Type.Fire, Type.Null },
            //60 - Poliwag
            new Type[] { Type.Water, Type.Null },
            //61 - Poliwhirl
            new Type[] { Type.Water, Type.Null },
            //62 - Poliwrath
            new Type[] { Type.Water, Type.Fighting },
            //63 - Abra
            new Type[] { Type.Psychic, Type.Null },
            //64 - Kadabra
            new Type[] { Type.Psychic, Type.Null },
            //65 - Alakazam
            new Type[] { Type.Psychic, Type.Null },
            //66 - Machop
            new Type[] { Type.Fighting, Type.Null },
            //67 - Machoke
            new Type[] { Type.Fighting, Type.Null },
            //68 - Machamp
            new Type[] { Type.Fighting, Type.Null },
            //69 - Bellsprout
            new Type[] { Type.Grass, Type.Poison },
            //70 - Weepinbell
            new Type[] { Type.Grass, Type.Poison },
            //71 - Victreebel
            new Type[] { Type.Grass, Type.Poison },
            //72 - Tentacool
            new Type[] { Type.Water, Type.Poison },
            //73 - Tentacruel
            new Type[] { Type.Water, Type.Poison },
            //74 - Geodude
            new Type[] { Type.Rock, Type.Ground },
            //75 - Graveler
            new Type[] { Type.Rock, Type.Ground },
            //76 - Golem
            new Type[] { Type.Rock, Type.Ground },
            //77 - Ponyta
            new Type[] { Type.Fire, Type.Null },
            //78 - Rapidash
            new Type[] { Type.Fire, Type.Null },
            //79 - Slowpoke
            new Type[] { Type.Water, Type.Psychic },
            //80 - Slowbrow
            new Type[] { Type.Water, Type.Psychic },
            //81 - Magnemite
            new Type[] { Type.Electric, Type.Null },
            //82 - Magneton
            new Type[] { Type.Electric, Type.Null },
            //83 - Farfetch'd
            new Type[] { Type.Normal, Type.Flying },
            //84 - Doduo
            new Type[] { Type.Normal, Type.Flying },
            //85 - Dodrio
            new Type[] { Type.Normal, Type.Flying },
            //86 - Seel
            new Type[] { Type.Water, Type.Null },
            //87 - Dewgong
            new Type[] { Type.Water, Type.Ice },
            //88 - Grimer
            new Type[] { Type.Poison, Type.Null },
            //89 - Muk
            new Type[] { Type.Poison, Type.Null },
            //90 - Shellder
            new Type[] { Type.Water, Type.Null },
            //91 - Cloyster
            new Type[] { Type.Water, Type.Ice },
            //92 - Gastly
            new Type[] { Type.Ghost, Type.Poison },
            //93 - Haunter
            new Type[] { Type.Ghost, Type.Poison },
            //94 - Gengar
            new Type[] { Type.Ghost, Type.Poison },
            //95 - Onix
            new Type[] { Type.Rock, Type.Ground },
            //96 - Drowzee
            new Type[] { Type.Psychic, Type.Null },
            //97 - Hypno
            new Type[] { Type.Psychic, Type.Null },
            //98 - Krabby
            new Type[] { Type.Water, Type.Null },
            //99 - Kingler
            new Type[] { Type.Water, Type.Null },
            //100 - Voltorb
            new Type[] { Type.Electric, Type.Null },
            //101 - Electrode
            new Type[] { Type.Electric, Type.Null },
            //102 - Exeggcute
            new Type[] { Type.Grass, Type.Psychic },
            //103 - Exeggutor
            new Type[] { Type.Grass, Type.Psychic },
            //104 - Cubone
            new Type[] { Type.Ground, Type.Null },
            //105 - Marowak
            new Type[] { Type.Ground, Type.Null },
            //106 - Hitmonlee
            new Type[] { Type.Fighting, Type.Null },
            //107 - Hitmonchan
            new Type[] { Type.Fighting, Type.Null },
            //108 - Lickitung
            new Type[] { Type.Normal, Type.Null },
            //109 - Koffing
            new Type[] { Type.Poison, Type.Null },
            //110 - Weezing
            new Type[] { Type.Poison, Type.Null },
            //111 - Rhyhorn
            new Type[] { Type.Ground, Type.Rock },
            //112 - Rhydon
            new Type[] { Type.Ground, Type.Rock },
            //113 - Chansey
            new Type[] { Type.Normal, Type.Null },
            //114 - Tangela
            new Type[] { Type.Grass, Type.Null },
            //115 - Kangaskhan
            new Type[] { Type.Normal, Type.Null },
            //116 - Horsea
            new Type[] { Type.Water, Type.Null },
            //117 - Seadra
            new Type[] { Type.Water, Type.Null },
            //118 - Goldeen
            new Type[] { Type.Water, Type.Null },
            //119 - Seaking
            new Type[] { Type.Water, Type.Null },
            //120 - Staryu
            new Type[] { Type.Water, Type.Null },
            //121 - Starmie
            new Type[] { Type.Water, Type.Psychic },
            //122 - Mr. Mime
            new Type[] { Type.Psychic, Type.Null },
            //123 - Scyther
            new Type[] { Type.Bug, Type.Flying },
            //124 - Jynx
            new Type[] { Type.Ice, Type.Psychic },
            //125 - Electabuzz
            new Type[] { Type.Electric, Type.Null },
            //126 - Magmar
            new Type[] { Type.Fire, Type.Null },
            //127 - Pinsir
            new Type[] { Type.Bug, Type.Null },
            //128 - Tauros
            new Type[] { Type.Normal, Type.Null },
            //129 - Magikarp
            new Type[] { Type.Water, Type.Null },
            //130 - Gyarados
            new Type[] { Type.Water, Type.Flying },
            //131 - Lapras
            new Type[] { Type.Water, Type.Ice },
            //132 - Ditto
            new Type[] { Type.Normal, Type.Null },
            //133 - Eevee
            new Type[] { Type.Normal, Type.Null },
            //134 - Vaporeon
            new Type[] { Type.Water, Type.Null },
            //135 - Jolteon
            new Type[] { Type.Electric, Type.Null },
            //136 - Flareon
            new Type[] { Type.Fire, Type.Null },
            //137 - Porygon
            new Type[] { Type.Normal, Type.Null },
            //138 - Omanyte
            new Type[] { Type.Rock, Type.Water },
            //139 - Omastar
            new Type[] { Type.Rock, Type.Water },
            //140 - Kabuto
            new Type[] { Type.Rock, Type.Water },
            //141 - Kabutops
            new Type[] { Type.Rock, Type.Water },
            //142 - Aerodactyl
            new Type[] { Type.Rock, Type.Flying },
            //143 - Snorlax
            new Type[] { Type.Normal, Type.Null },
            //144 - Articuno
            new Type[] { Type.Ice, Type.Flying },
            //145 - Zapdos
            new Type[] { Type.Electric, Type.Flying },
            //146 - Moltres
            new Type[] { Type.Fire, Type.Flying },
            //147 - Dratini
            new Type[] { Type.Dragon, Type.Null },
            //148 - Dragonair
            new Type[] { Type.Dragon, Type.Null },
            //149 - Dragonite
            new Type[] { Type.Dragon, Type.Flying },
            //150 - Mewtwo
            new Type[] { Type.Psychic, Type.Null },
            //151 - Mew
            new Type[] { Type.Psychic, Type.Null }
        };
        


        
        public static readonly ExperienceGroup[] ExpGroup = new ExperienceGroup[]
        {
            //0 - No Pokemon
            ExperienceGroup.Fast,
            //1 - Bulbasaur
            ExperienceGroup.MediumSlow,
            //2 - Ivysaur
            ExperienceGroup.MediumSlow,
            //3 - Venusaur
            ExperienceGroup.MediumSlow,
            //4 - Charmander
            ExperienceGroup.MediumSlow,
            //5 - Charmeleon
            ExperienceGroup.MediumSlow,
            //6 - Charizard
            ExperienceGroup.MediumSlow,
            //7 - Squirtle
            ExperienceGroup.MediumSlow,
            //8 - Wartortle
            ExperienceGroup.MediumSlow,
            //9 - Blastoise
            ExperienceGroup.MediumSlow,
            //10 - Caterpie
            ExperienceGroup.MediumFast,
            //11 - Metapod
            ExperienceGroup.MediumFast,
            //12 - Butterfree
            ExperienceGroup.MediumFast,
            //13 - Weedle
            ExperienceGroup.MediumFast,
            //14 - Kakuna
            ExperienceGroup.MediumFast,
            //15 - Beedrill
            ExperienceGroup.MediumFast,
            //16 - Pidgey
            ExperienceGroup.MediumSlow,
            //17 - Pidgeotto
            ExperienceGroup.MediumSlow,
            //18 - Pidgeot
            ExperienceGroup.MediumSlow,
            //19 - Rattata
            ExperienceGroup.MediumFast,
            //20 - Raticate
            ExperienceGroup.MediumFast,
            //21 - Spearow
            ExperienceGroup.MediumFast,
            //22 - Fearow
            ExperienceGroup.MediumFast,
            //23 - Ekans
            ExperienceGroup.MediumFast,
            //24 - Arbok
            ExperienceGroup.MediumFast,
            //25 - Pikachu
            ExperienceGroup.MediumFast,
            //26 - Raichu
            ExperienceGroup.MediumFast,
            //27 - Sandshrew
            ExperienceGroup.MediumFast,
            //28 - Sandslash
            ExperienceGroup.MediumFast,
            //29 - Nidoran Female
            ExperienceGroup.MediumSlow,
            //30 - Nidorina
            ExperienceGroup.MediumSlow,
            //31 - Nidoqueen
            ExperienceGroup.MediumSlow,
            //32 - Nidoran Male
            ExperienceGroup.MediumSlow,
            //33 - Nidorino
            ExperienceGroup.MediumSlow,
            //34 - Nidoking
            ExperienceGroup.MediumSlow,
            //35 - Clefairy
            ExperienceGroup.Fast,
            //36 - Clefable
            ExperienceGroup.Fast,
            //37 - Vulpix
            ExperienceGroup.MediumFast,
            //38 - Ninetails
            ExperienceGroup.MediumFast,
            //39 - Jigglypuff
            ExperienceGroup.Fast,
            //40 - Wigglytuff
            ExperienceGroup.Fast,
            //41 - Zubat
            ExperienceGroup.MediumFast,
            //42 - Golbat
            ExperienceGroup.MediumFast,
            //43 - Oddish
            ExperienceGroup.MediumSlow,
            //44 - Gloom
            ExperienceGroup.MediumSlow,
            //45 - Vileplume
            ExperienceGroup.MediumSlow,
            //46 - Paras
            ExperienceGroup.MediumFast,
            //47 - Parasect
            ExperienceGroup.MediumFast,
            //48 - Venonat
            ExperienceGroup.MediumFast,
            //49 - Venomoth
            ExperienceGroup.MediumFast,
            //50 - Diglett
            ExperienceGroup.MediumFast,
            //51 - Dugtrio
            ExperienceGroup.MediumFast,
            //52 - Meowth
            ExperienceGroup.MediumFast,
            //53 - Persian
            ExperienceGroup.MediumFast,
            //54 - Psyduck
            ExperienceGroup.MediumFast,
            //55 - Golduck
            ExperienceGroup.MediumFast,
            //56 - Mankey
            ExperienceGroup.MediumFast,
            //57 - Primeape
            ExperienceGroup.MediumFast,
            //58 - Growlithe
            ExperienceGroup.Slow,
            //59 - Arcanine
            ExperienceGroup.Slow,
            //60 - Poliwag
            ExperienceGroup.MediumSlow,
            //61 - Poliwhirl
            ExperienceGroup.MediumSlow,
            //62 - Poliwhirl
            ExperienceGroup.MediumSlow,
            //63 - Abra
            ExperienceGroup.MediumSlow,
            //64 - Kadabra
            ExperienceGroup.MediumSlow,
            //65 - Alakazam
            ExperienceGroup.MediumSlow,
            //66 - Machop
            ExperienceGroup.MediumSlow,
            //67 - Machoke
            ExperienceGroup.MediumSlow,
            //68 - Machamp
            ExperienceGroup.MediumSlow,
            //69 - Bellsprout
            ExperienceGroup.MediumSlow,
            //70 - Weepinbell
            ExperienceGroup.MediumSlow,
            //71 - Victreebel
            ExperienceGroup.MediumSlow,
            //72 - Tentacool
            ExperienceGroup.Slow,
            //73 - Tentacruel
            ExperienceGroup.Slow,
            //74 - Geodude
            ExperienceGroup.MediumSlow,
            //75 - Graveler
            ExperienceGroup.MediumSlow,
            //76 - Golem
            ExperienceGroup.MediumSlow,
            //77 - Ponyta
            ExperienceGroup.MediumFast,
            //78 - Rapidash
            ExperienceGroup.MediumFast,
            //79 - Slowpoke
            ExperienceGroup.MediumFast,
            //80 Slowbrow
            ExperienceGroup.MediumFast,
            //81 - Magnemite
            ExperienceGroup.MediumFast,
            //82 - Magneton
            ExperienceGroup.MediumFast,
            //83 - Farfetch'd
            ExperienceGroup.MediumFast,
            //84 - Doduo
            ExperienceGroup.MediumFast,
            //85 - Dodrio
            ExperienceGroup.MediumFast,
            //86 - Seel
            ExperienceGroup.MediumFast,
            //87 - Dewgong
            ExperienceGroup.MediumFast,
            //88 - Grimer
            ExperienceGroup.MediumFast,
            //89 - Muk
            ExperienceGroup.MediumFast,
            //90 - Shellder
            ExperienceGroup.Slow,
            //91 - Cloyster
            ExperienceGroup.Slow,
            //92 - Gastly
            ExperienceGroup.MediumSlow,
            //93 - Haunter
            ExperienceGroup.MediumSlow,
            //94 - Gengar
            ExperienceGroup.MediumSlow,
            //95 - Onix
            ExperienceGroup.MediumFast,
            //96 - Drowzee
            ExperienceGroup.MediumFast,
            //97 - Hypno
            ExperienceGroup.MediumFast,
            //98 - Krabby
            ExperienceGroup.MediumFast,
            //99 - Kingler
            ExperienceGroup.MediumFast,
            //100 - Voltorb
            ExperienceGroup.MediumFast,
            //101 - Electrode
            ExperienceGroup.MediumFast,
            //102 - Exeggcute
            ExperienceGroup.Slow,
            //103 - Exeggutor
            ExperienceGroup.Slow,
            //104 - Cubone
            ExperienceGroup.MediumFast,
            //105 - Marowak
            ExperienceGroup.MediumFast,
            //106 - Hitmonlee
            ExperienceGroup.MediumFast,
            //107 - Hitmonchan
            ExperienceGroup.MediumFast,
            //108 - Lickitung
            ExperienceGroup.MediumFast,
            //109 - Koffing
            ExperienceGroup.MediumFast,
            //110 - Weezing
            ExperienceGroup.MediumFast,
            //111 - Rhyhorn
            ExperienceGroup.Slow,
            //112 - Rhydon
            ExperienceGroup.Slow,
            //113 - Chansey
            ExperienceGroup.Fast,
            //114 - Tangela
            ExperienceGroup.MediumFast,
            //115 - Kangaskhan
            ExperienceGroup.MediumFast,
            //116 - Horsea
            ExperienceGroup.MediumFast,
            //117 - Seadra
            ExperienceGroup.MediumFast,
            //118 - Goldeen
            ExperienceGroup.MediumFast,
            //119 - Seaking
            ExperienceGroup.MediumFast,
            //120 - Staryu
            ExperienceGroup.Slow,
            //121 - Starmie
            ExperienceGroup.Slow,
            //122 - Mr. Mime
            ExperienceGroup.MediumFast,
            //123 - Scyther
            ExperienceGroup.MediumFast,
            //124 - Jynx
            ExperienceGroup.MediumFast,
            //125 - Electabuzz
            ExperienceGroup.MediumFast,
            //126 - Magmar
            ExperienceGroup.MediumFast,
            //127 - Pinsir
            ExperienceGroup.Slow,
            //128 - Tauros
            ExperienceGroup.Slow,
            //129 - Magikarp
            ExperienceGroup.Slow,
            //130 - Gyarados
            ExperienceGroup.Slow,
            //131 - Lapras
            ExperienceGroup.Slow,
            //132 - Ditto
            ExperienceGroup.MediumFast,
            //133 - Eevee
            ExperienceGroup.MediumFast,
            //134 - Vaporeon
            ExperienceGroup.MediumFast,
            //135 - Jolteon
            ExperienceGroup.MediumFast,
            //136 - Flareon
            ExperienceGroup.MediumFast,
            //137 - Porygon
            ExperienceGroup.MediumFast,
            //138 - Omanyte
            ExperienceGroup.MediumFast,
            //139 - Omastar
            ExperienceGroup.MediumFast,
            //140 - Kabuto
            ExperienceGroup.MediumFast,
            //141 - Kabutops
            ExperienceGroup.MediumFast,
            //142 - Aerodactyl
            ExperienceGroup.Slow,
            //143 - Snorlax
            ExperienceGroup.Slow,
            //144 - Articuno
            ExperienceGroup.Slow,
            //145 - Zapdos
            ExperienceGroup.Slow,
            //146 - Moltres
            ExperienceGroup.Slow,
            //147 - Dratini
            ExperienceGroup.Slow,
            //148 - Dragonair
            ExperienceGroup.Slow,
            //149 - Dragonite
            ExperienceGroup.Slow,
            //150 - Mewtwo
            ExperienceGroup.Slow,
            //151 - Mew
            ExperienceGroup.MediumSlow
        };


        

        public static readonly Stats[] BaseStats = new Stats[]
        {   // 0 - No Pokemon
            new Stats(0f, 0f, 0f, 0f, 0f),
            // 1 - Bulbasaur
            new Stats(45f, 49f, 49f, 65f, 45f),
            // 2 - Ivysaur
            new Stats(60f, 62f, 63f, 80f, 60f),
            // 3 - Venusaur
            new Stats(80f, 82f, 83f, 100f, 80f),
            // 4 - Charmander
            new Stats(39f, 52f, 43f, 50f, 65f),
            // 5 - Charmeleon
            new Stats(58f, 64f, 58f, 65f, 80f),
            // 6 - Charizard
            new Stats(78f, 84f, 78f, 85f, 100f),
            // 7 - Squirtle
            new Stats(44f, 48f, 65f, 50f, 43f),
            // 8 - Wartortle
            new Stats(59f, 63f, 80f, 65f, 58f),
            // 9 - Blastoise
            new Stats(79f, 83f, 100f, 85f, 78f),
            // 10 - Caterpie
            new Stats(45f, 30f, 35f, 20f, 45f),
            // 11 - Metapod
            new Stats(50f, 20f, 55f, 25f, 30f),
            // 12 - Butterfree
            new Stats(60f, 45f, 50f, 80f, 70f),
            // 13 - Weedle
            new Stats(40f, 35f, 30f, 20f, 50f),
            // 14 - Kakuna
            new Stats(45f, 25f, 50f, 25f, 35f),
            // 15 - Beedrill
            new Stats(65f, 80f, 40f, 45f, 75f),
            // 16 - Pidgey
            new Stats(40f, 45f, 40f, 35f, 56f),
            // 17 - Pidgeotto
            new Stats(63f, 60f, 55f, 50f, 71f),
            // 18 - Pidgeot
            new Stats(83f, 80f, 75f, 70f, 91f),
            // 19 - Rattata
            new Stats(30f, 56f, 35f, 25f, 72f),
            // 20 - Raticate
            new Stats(55f, 81f, 60f, 50f, 97f),
            // 21 - Spearow
            new Stats(40f, 60f, 30f, 31f, 70f),
            // 22 - Fearow
            new Stats(65f, 90f, 65f, 61f, 100f),
            // 23 - Ekans
            new Stats(35f, 60f, 44f, 40f, 55f),
            // 24 - Arbok
            new Stats(60f, 85f, 69f, 65f, 80f),
            // 25 - Pikachu
            new Stats(35f, 55f, 30f, 50f, 90f),
            // 26 - Raichu
            new Stats(60f, 90f, 55f, 90f, 100f),
            // 27 - Sandshrew
            new Stats(50f, 75f, 85f, 30f, 40f),
            // 28 - Sandslash
            new Stats(75f, 100f, 110f, 55f, 65f),
            // 29 - Nidoran Female
            new Stats(55f, 47f, 52f, 40f, 41f),
            // 30 - Nidorina
            new Stats(70f, 62f, 67f, 55f, 56f),
            // 31 - Nidoqueen
            new Stats(90f, 82f, 87f, 75f, 76f),
            // 32 - Nidoran Male
            new Stats(46f, 57f, 40f, 40f, 50f),
            // 33 - Nidorino
            new Stats(61f, 72f, 57f, 55f, 65f),
            // 34 - Nidoking
            new Stats(81f, 92f, 77f, 75f, 85f),
            // 35 - Clefairy
            new Stats(70f, 45f, 48f, 60f, 35f),
            // 36 - Clefable
            new Stats(95f, 70f, 73f, 85f, 60f),
            // 37 - Vulpix
            new Stats(38f, 41f, 40f, 65f, 65f),
            // 38 - Ninetails
            new Stats(73f, 76f, 75f, 100f, 100f),
            // 39 - Jigglypuff
            new Stats(115f, 45f, 20f, 25f, 20f),
            // 40 - Wigglytuff
            new Stats(140f, 70f, 45f, 50f, 45f),
            // 41 - Zubat
            new Stats(40f, 45f, 35f, 40f, 55f),
            // 42 - Golbat
            new Stats(75f, 80f, 70f, 75f, 90f),
            // 43 - Oddish
            new Stats(45f, 50f, 55f, 75f, 30f),
            // 44 - Gloom
            new Stats(60f, 65f, 70f, 85f, 40f),
            // 45 - Vileplume
            new Stats(75f, 80f, 85f, 100f, 50f),
            // 46 - Paras
            new Stats(35f, 70f, 55f, 55f, 25f),
            // 47 - Parasect
            new Stats(60f, 95f, 80f, 80f, 30f),
            // 48 - Venonat
            new Stats(60f, 55f, 50f, 40f, 45f),
            // 49 - Venomoth
            new Stats(70f, 65f, 60f, 90f, 90f),
            // 50 - Diglett
            new Stats(10f, 55f, 25f, 45f, 95f),
            // 51 - Dugtrio
            new Stats(35f, 80f, 50f, 70f, 120f),
            // 52 - Meowth
            new Stats(40f, 45f, 35f, 40f, 90f),
            // 53 - Persian
            new Stats(65f, 70f, 60f, 65f, 115f),
            // 54 - Psyduck
            new Stats(50f, 52f, 48f, 50f, 55f),
            // 55 - Golduck
            new Stats(80f, 82f, 78f, 80f, 85f),
            // 56 - Mankey
            new Stats(40f, 80f, 35f, 35f, 70f),
            // 57 - Primeape
            new Stats(65f, 105f, 60f, 60f, 95f),
            // 58 - Growlithe
            new Stats(55f, 70f, 45f, 50f, 60f),
            // 59 - Arcanine
            new Stats(90f, 110f, 80f, 80f, 95f),
            // 60 - Poliwag
            new Stats(40f, 50f, 40f, 40f, 90f),
            // 61 - Poliwhirl
            new Stats(65f, 65f, 65f, 50f, 90f),
            // 62 - Poliwrath
            new Stats(90f, 85f, 95f, 70f, 70f),
            // 63 - Abra
            new Stats(25f, 20f, 15f, 105f, 90f),
            // 64 - Kadabra
            new Stats(40f, 35f, 30f, 120f, 105f),
            // 65 - Alakazam
            new Stats(55f, 50f, 45f, 135f, 120f),
            // 66 - Machop
            new Stats(70f, 80f, 50f, 35f, 35f),
            // 67 - Machoke
            new Stats(80f, 100f, 70f, 50f, 45f),
            // 68 - Machamp
            new Stats(90f, 130f, 80f, 65f, 55f),
            // 69 - Bellsprout
            new Stats(50f, 75f, 35f, 70f, 40f),
            // 70 - Weepinbell
            new Stats(65f, 90f, 50f, 85f, 55f),
            // 71 - Victreebel
            new Stats(80f, 105f, 65f, 100f, 70f),
            // 72 - Tentacool
            new Stats(40f, 40f, 35, 100f, 70f),
            // 73 - Tentacruel
            new Stats(80f, 70f, 65f, 120f, 100f),
            // 74 - Geodude
            new Stats(40f, 80f, 100f, 30f, 20f),
            // 75 - Graveler
            new Stats(55f, 95f, 115f, 45f, 35f),
            // 76 - Golem
            new Stats(80f, 110f, 130f, 55f, 45f),
            // 77 - Ponyta
            new Stats(50f, 85f, 55f, 65f, 90f),
            // 78 - Rapidash
            new Stats(65f, 100f, 70f, 80f, 105f),
            // 79 - Slowpoke
            new Stats(90f, 65f, 65f, 40f, 15f),
            // 80 - Slowbro
            new Stats(95f, 75f, 110f, 80f, 30f),
            // 81 - Magnemite
            new Stats(25f, 35f, 70f, 95f, 45f),
            // 82 - Magneton
            new Stats(50f, 60f, 95f, 120f, 70f),
            // 83 - Fatfetchd
            new Stats(52f, 65f, 55f, 58f, 60f),
            // 84 - Doduo
            new Stats(35f, 85f, 45f, 35f, 75f),
            // 85 - Dodrio
            new Stats(60f, 110f, 70f, 60f, 100f),
            // 86 - Seel
            new Stats(65f, 45f, 55f, 70f, 45f),
            // 87 - Dewgong
            new Stats(90f, 70f, 80f, 95f, 70f),
            // 88 - Grimer
            new Stats(80f, 80f, 50f, 40f, 25f),
            // 89 - Muk
            new Stats(105f, 105f, 75f, 65f, 50f),
            // 90 - Shellder
            new Stats(30f, 65f, 100f, 45f, 40f),
            // 91 - Cloyster
            new Stats(50f, 95f, 180f, 85f, 70f),
            // 92 - Gastly
            new Stats(30f, 35f, 30f, 100f, 80f),
            // 93 - Haunter
            new Stats(45f, 50f, 45f, 115f, 95f),
            // 94 - Gengar
            new Stats(60f, 65f, 60f, 130f, 110f),
            // 95 - Onix
            new Stats(35f, 45f, 160f, 30f, 70f),
            // 96 - Drowzee
            new Stats(60f, 48f, 45f, 90f, 42f),
            // 97 - Hypno
            new Stats(85f, 73f, 70f, 115f, 67f),
            // 98 - Krabby
            new Stats(30f, 105f, 90f, 25f, 50f),
            // 99 - Kingler
            new Stats(55f, 130f, 115f, 50f, 75f),
            // 100 - Voltorb
            new Stats(40f, 30f, 50f, 55f, 100f),
            // 101 - Electrode
            new Stats(60f, 50f, 70f, 80f, 140f),
            // 102 - Exeggcute
            new Stats(60f, 40f, 80f, 60f, 40f),
            // 103 - Exeggutor
            new Stats(95f, 95f, 85f, 125f, 55f),
            // 104 - Cubone
            new Stats(50f, 50f, 95f, 40f, 35f),
            // 105 - Marowak
            new Stats(60f, 80f, 110f, 50f, 45f),
            // 106 - Hitmonlee
            new Stats(50f, 120f, 53f, 35f, 87f),
            // 107 - Hitmonchan
            new Stats(50f, 105f, 79f, 35f, 76f),
            // 108 - Lickitung
            new Stats(90f, 55f, 75f, 60f, 30f),
            // 109 - Koffing
            new Stats(40f, 65f, 95f, 60f, 35f),
            // 110 - Weezing
            new Stats(65f, 90f, 120f, 85f, 60f),
            // 111 - Rhyhorn
            new Stats(80f, 85f, 95f, 30f, 25f),
            // 112 - Rhydon
            new Stats(105f, 130f, 120f, 45f, 40f),
            // 113 - Chansey
            new Stats(250f, 5f, 5f, 105f, 50f),
            // 114 - Tangela
            new Stats(65f, 55f, 115f, 100f, 60f),
            // 115 - Kangaskhan
            new Stats(105f, 95f, 80f, 40f, 90f),
            // 116 - Horsea
            new Stats(30f, 40f, 70f, 70f, 60f),
            // 117 - Seadra
            new Stats(55f, 65f, 95f, 95f, 85f),
            // 118 - Goldeen
            new Stats(45f, 67f, 60f, 50f, 63f),
            // 119 - Seaking
            new Stats(80f, 92f, 65f, 80f, 68f),
            // 120 - Staryu
            new Stats(30f, 45f, 55f, 70f, 85f),
            // 121 - Starmie
            new Stats(60f, 75f, 85f, 100f, 115f),
            // 122 - Mr. Mime
            new Stats(40f, 45f, 65f, 100f, 90f),
            // 123 - Scyther
            new Stats(70f, 110f, 80f, 55f, 105f),
            // 124 - Jynx
            new Stats(65f, 50f, 35f, 95f, 95f),
            // 125 - Electabuzz
            new Stats(65f, 83f, 57f, 85f, 105f),
            // 126 - Magmar
            new Stats(65f, 95f, 57f, 85f, 93f),
            // 127 - Pinsir
            new Stats(65f, 125f, 100f, 55f, 85f),
            // 128 - Tauros
            new Stats(75f, 100f, 95f, 70f, 110f),
            // 129 - Magikarp
            new Stats(20f, 10f, 55f, 20f, 80f),
            // 130 - Gyarados
            new Stats(95f, 125f, 79f, 100f, 81f),
            // 131 - Lapras
            new Stats(130, 85f, 80f, 95f, 60f),
            // 132 - Ditto
            new Stats(48f, 48f, 48f, 48f, 48f),
            // 133 - Eevee
            new Stats(55f, 55f, 50f, 65f, 55f),
            // 134 - Vaporeon
            new Stats(130f, 65f, 60f, 110f, 65f),
            // 135 - Jolteon
            new Stats(65f, 65f, 60f, 110f, 130f),
            // 136 - Flareon
            new Stats(65f, 130f, 60f, 110f, 65f),
            // 137 - Porygon
            new Stats(65f, 60f, 70f, 75f, 40f),
            // 138 - Omanyte
            new Stats(35f, 40f, 100f, 90f, 35f),
            // 139 - Omastar
            new Stats(70f, 60f, 125f, 115f, 55f),
            // 140 - Kabuto
            new Stats(30f, 80f, 90f, 45f, 55f),
            // 141 - Kabutops
            new Stats(60f, 115f, 105f, 70f, 80f),
            // 142 - Aerodactyl
            new Stats(80f, 105f, 65f, 60f, 130f),
            // 143 - Snorlax
            new Stats(160f, 110f, 65f, 65f, 30f),
            // 144 - Articuno
            new Stats(90f, 85f, 100f, 125f, 85f),
            // 145 - Zapos
            new Stats(90f, 90f, 85f, 125f, 100f),
            // 146 - Moltres
            new Stats(90f, 100f, 90f, 125f, 90f),
            // 147 - Dratini
            new Stats(41f, 64f, 45f, 50f, 50f),
            // 148 - Dragonair
            new Stats(61f, 84f, 65f, 70f, 70f),
            // 149 - Dragonite
            new Stats(91f, 134f, 95f, 100f, 80f),
            // 150 - Mewtwo
            new Stats(106f, 110f, 90f, 154f, 130f),
            // 151 - Mew
            new Stats(100f, 100f, 100f, 100f, 100f)
        };


        public static readonly float[] CatchRate = new float[]
        {
            0f,   //0 - NoPokemon
            45f,  //1 - Bulbasaur
            45f,  //2 - Ivysaur
            45f,  //3 - Venusaur
            45f,  //4 - Charmander
            45f,  //5 - Charmeleon
            45f,  //6 - Charizard
            45f,  //7 - Squirtle
            45f,  //8 - Wartortle
            45f,  //9 - Blastoise
            255f, //10 - Caterpie
            120f, //11 - Metapod
            45f,  //12 - Butterfree

            //FINISH (numbers wrong below)

            52f,  //13 - Weedle
            71f,  //14 - Kakuna
            159f, //15 - Beedrill
            55f,  //16 - Pidgey
            113f, //17 - Pidgeotto
            172f, //18 - Pidgeot
            57f,  //19 - Rattata
            116f, //20 - Raticate
            58f,  //21 - Spearow
            163f, //22 - Fearow
            62f,  //23 - Ekans
            147f, //24 - Arbok
            82f,  //25 - Pikachu
            122f, //26 - Raichu
            93f,  //27 - Sandshrew
            163f, //28 - Sandslash
            59f,  //29 - Nidoran Female
            117f, //30 - Nidorina
            194f, //31 - Nidoqueen
            60f,  //32 - Nidoran Male
            118f, //33 - Nidorino
            195f, //34 - Nidoking
            68f,  //35 - Clefairy
            129f, //36 - Clefable
            63f,  //37 - Vulpix
            178f, //38 - Ninetails
            76f,  //39 - Jigglypuff
            109f, //40 - Wigglytuff
            54f,  //41 - Zubat
            171f, //42 - Golbat
            78f,  //43 - Oddish
            132f, //44 - Gloom
            184f, //45 - Vileplume
            70f,  //46 - Paras
            128f, //47 - Parasect
            75f,  //48 - Venonat
            138f, //49 - Venomoth
            81f,  //50 - Diglett
            153f, //51 - Dugtrio
            69f,  //52 - Meowth
            148f, //53 - Persian
            80f,  //54 - Psyduck
            174f, //55 - Golduck
            74f,  //56 - Mankey
            149f, //57 - Primeape
            91f,  //58 - Growlithe
            213f, //59 - Arcanine
            77f,  //60 - Poliwag
            131f, //61 - Poliwhirl
            185f, //62 - Poliwrath
            73f,  //63 - Abra
            145f, //64 - Kadabra
            186f, //65 - Alakazam
            88f,  //66 - Machop
            146f, //67 - Machoke
            193f, //68 - Machamp
            84f,  //69 - Bellsprout
            151f, //70 - Weepinbell
            191f, //71 - Victreebel
            105f, //72 - Tentacool
            205f, //73 - Tentacruel
            86f,  //74 - Geodude
            134f, //75 - Graveler
            177f, //76 - Golem
        };


        
        public static readonly float[] ExpYield = new float[]
        {
            0f,   //0 - NoPokemon
            64f,  //1 - Bulbasaur
            141f, //2 - Ivysaur
            208f, //3 - Venusaur
            65f,  //4 - Charmander
            142f, //5 - Charmeleon
            209f, //6 - Charizard
            66f,  //7 - Squirtle
            143f, //8 - Wartortle
            210f, //9 - Blastoise
            53f,  //10 - Caterpie
            72f,  //11 - Metapod
            160f, //12 - Butterfree
            52f,  //13 - Weedle
            71f,  //14 - Kakuna
            159f, //15 - Beedrill
            55f,  //16 - Pidgey
            113f, //17 - Pidgeotto
            172f, //18 - Pidgeot
            57f,  //19 - Rattata
            116f, //20 - Raticate
            58f,  //21 - Spearow
            163f, //22 - Fearow
            62f,  //23 - Ekans
            147f, //24 - Arbok
            82f,  //25 - Pikachu
            122f, //26 - Raichu
            93f,  //27 - Sandshrew
            163f, //28 - Sandslash
            59f,  //29 - Nidoran Female
            117f, //30 - Nidorina
            194f, //31 - Nidoqueen
            60f,  //32 - Nidoran Male
            118f, //33 - Nidorino
            195f, //34 - Nidoking
            68f,  //35 - Clefairy
            129f, //36 - Clefable
            63f,  //37 - Vulpix
            178f, //38 - Ninetails
            76f,  //39 - Jigglypuff
            109f, //40 - Wigglytuff
            54f,  //41 - Zubat
            171f, //42 - Golbat
            78f,  //43 - Oddish
            132f, //44 - Gloom
            184f, //45 - Vileplume
            70f,  //46 - Paras
            128f, //47 - Parasect
            75f,  //48 - Venonat
            138f, //49 - Venomoth
            81f,  //50 - Diglett
            153f, //51 - Dugtrio
            69f,  //52 - Meowth
            148f, //53 - Persian
            80f,  //54 - Psyduck
            174f, //55 - Golduck
            74f,  //56 - Mankey
            149f, //57 - Primeape
            91f,  //58 - Growlithe
            213f, //59 - Arcanine
            77f,  //60 - Poliwag
            131f, //61 - Poliwhirl
            185f, //62 - Poliwrath
            73f,  //63 - Abra
            145f, //64 - Kadabra
            186f, //65 - Alakazam
            88f,  //66 - Machop
            146f, //67 - Machoke
            193f, //68 - Machamp
            84f,  //69 - Bellsprout
            151f, //70 - Weepinbell
            191f, //71 - Victreebel
            105f, //72 - Tentacool
            205f, //73 - Tentacruel
            86f,  //74 - Geodude
            134f, //75 - Graveler
            177f, //76 - Golem
        };
    }
}
