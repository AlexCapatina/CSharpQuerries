using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1Lab4
{
    public class Country
    {
        public string Name { get; }
        public int Land { get; }
        public int Water { get; }
        public bool IsLandLocked { get; }
        public List<string> Borders { get; }
        public int Coastline { get; }
        public List<string> Resources { get; }
        public int Population { get; }
        public List<string> Languages { get; }
        public List<string> Religions { get; }
        public Country(string name, int land, int water, List<string> borders, int coastline, List<string> resources, int population, List<string> languages, List<string> religions, bool isLandLocked = false)
        {
            Name = name; Land = land; Water = water; Borders = borders; Coastline = coastline; Resources = resources;
            Population = population; Languages = languages; Religions = religions; IsLandLocked = isLandLocked;
        }

        public static List<Country> GetCountries()
        {
            return new List<Country>()
            {
                new Country( "Venezuela", 882050, 30000,
                            new List<string>{ "Brazil", "Colombia", "Guyana" }, 2800,
                            new List<string>{ "petroleum", "natural gas", "iron ore", "gold", "bauxite", "other minerals", "hydropower", "diamonds" },
                            31304016,
                            new List<string>{ "Spanish" },
                            new List<string>{"Roman Catholic", "Protestant" } ),
                new Country( "Peru", 127006, 5220,
                            new List<string> { "Boliva", "Brazil", "Chile", "Columbia", "Ecuador" }, 4214,
                            new List<string> { "copper", "silver", "gold", "petroleum", "timber", "fish", "iron ore", "coal", "phosphate", "potash", "hydropower", "natural gas" }, 31036656,
                            new List<string> { "Spanish", "Quechua", "Aymara", "Ashaninka" },
                            new List<string> { "Roman Catholic", "Evangelical" } ),
                new Country( "Paraguay", 397302, 9450,
                            new List<string> { "Argentina", "Boliva", "Brazil" }, 0,
                            new List<string> { "hydropower", "timber", "iron ore", "manganese", "limestone" }, 6943739,
                            new List<string> { "Spanish", "Guarani" },
                            new List<string> { "Roman Catholic", "Protestant" },
                            true ),
                new Country( "Bolivia", 1083301, 15280,
                            new List<string>{ "Argentina", "Brazil", "Chile", "Paragua", "Peru" }, 0,
                            new List<string>{ "tin", "natural gas", "petroleum", "zinc", "tungsten", "antimony", "silver", "iron", "lead", "gold", "timber", "hydropower" }, 11138234,
                            new List<string>{ "Spanish", "Quechua", "Aymara", "Guarani"},
                            new List<string>{ "Roman Catholic", "Evangelical", "Protestant"},
                            true ),
                new Country( "Chile", 743812, 12290,
                            new List<string>{ "Argentina", "Boliva", "Peru" }, 6435,
                            new List<string>{ "copper", "timber", "iron ore", "nitrates", "precious metals", "molybdenum", "hydropower" }, 1778267,
                            new List<string>{ "Spanish", "English", "Mapudengun", "Aymara", "Quechua", "Rapa Nui"},
                            new List<string>{ "Roman Catholic", "Evangelical", "Jehovah's Witness"} ),
                new Country( "Argentina", 2736690, 43710,
                            new List<string>{ "Boliva", "Brazil", "Chile", "Paraguay", "Uruguay" }, 4989,
                            new List<string>{ "fertile plains of the pampas", "lead", "zinc", "tin", "copper", "iron ore", "manganese", "petroleum", "uranium", "arable land" }, 44293293,
                            new List<string>{ "Spanish", "Italian", "English", "German", "French"},
                            new List<string>{ "Roman Catholic", "Protestant", "Jewish"} ),
                new Country( "Guyana", 196849, 18120,
                            new List<string>{ "Brazil", "Suriname", "Venezuela" }, 459,
                            new List<string>{ "bauxite", "gold", "diamonds", "hardwood", "timber", "shrimp", "fish" }, 737718,
                            new List<string>{ "English"},
                            new List<string>{ "Pentacostal", "Adventist", "Anglican", "Methodist", "Hindu", "Roman Catholic", "Muslim", "Jehovah's Witness", "Rastafarian" } ),
                new Country( "French Guiana", 89150, 1850,
                            new List<string>{ "Brazil", "Suriname" }, 378,
                            new List<string>{ "shrimp", "timber", "gold", "rum" }, 191309,
                            new List<string>{ "French" },
                            new List<string>{ "Roman Catholic" } ),
                new Country( "Suriname", 156000, 7820,
                            new List<string>{ "Brazil", "French Guiana", "Guyana" }, 386,
                            new List<string>{ "timber", "hydropower", "fish", "kaolin", "shrimp", "bauxite", "gold", "nickel", "copper", "platinum", "iron ore" }, 591919,
                            new List<string>{ "Dutch", "English", "Taki-taki" },
                            new List<string>{ "Protestant", "Hindu", "Roman Catholic", "Muslim", "Jehovah's Witness" } ),
                new Country( "Brazil", 8358140, 157630,
                            new List<string>{ "Argentina", "Bolivia", "Colombia", "French Guiana", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" }, 7491,
                            new List<string>{ "bauxite", "gold", "iron ore", "manganese", "nickel", "phosphate", "platinum", "tin", "rare earth elements", "uranium", "petroleum", "hydropower", "timber" }, 207353391,
                            new List<string>{ "Portuguese", "Spanish", "German", "Italian", "Japanese", "English" },
                            new List<string>{ "Roman Catholic", "Adventist", "Assembly of God" } ),
                new Country( "Ecuador", 276841, 6720,
                            new List<string>{ "Colombia", "Peru" }, 2237,
                            new List<string>{ "petroleum", "fish", "timber", "hydropower" }, 16290913,
                            new List<string>{ "Spanish", "Quechua" },
                            new List<string>{ "Roman Catholic", "Evangelical", "Jehovah's Witness", "Mormon", "Jewish", "Muslim", "Hindu" } ),
                new Country( "Uruguay", 175015, 1200,
                            new List<string>{ "Argentina", "Brazil" }, 669,
                            new List<string>{ "arable land", "hydropower", "minor minerals", "fish" }, 3360148,
                            new List<string>{ "Spanish", "Portunol", "Brazilero" },
                            new List<string>{ "Roman Catholic", "Jewish" })
            };
        }

        public override string ToString() =>
        $"\n{Name} {Population}m {Land} + {Water}kms {Coastline}km  {(IsLandLocked ? "(Landlocked)" : "")}\nNeighbors: {String.Join(", ", Borders)} \nResources: {string.Join(", ", Resources)} \nLanguages: {string.Join(", ", Languages)}, \nReligions: {string.Join(", ", Religions)}";

    }
}
