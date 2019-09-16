

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ia
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }



        static object[,] rel = { { "Satu Mare", 47.7628, 22.8547 },//1
                                { "Baia Mare",47.6438, 23.5478},//2
                                {"Zalau",47.1924, 23.0161 },//3
                                {"Bistrita" ,47.1254, 24.4673},//4
                                {"Cluj Napoca" ,46.7381, 23.5711},//5
                                {"Targu Mures" ,46.5431, 24.5157},//6
                                {"Miercurea Ciuc",46.3484, 25.8116 },//7
                                {"Oradea", 47.0746, 21.8674 },//8
                                {"Arad", 46.1752,21.2363 },//9
                                {"Timisoara",45.7412,21.0761 },//10
                                {"Deva", 45.8757,22.8430 },//11
                                {"Sibiu",45.7830,24.0697 },//12
                                { "Craiova",44.3232 ,23.7366},//13
                                {"Bucuresti",44.4379,25.9545 },//14
                                {"Suceava",47.6639, 26.1915},//15
                                {"Iasi",47.1562, 27.5169},//16
                                {"Bacau",46.5641,26.8388 },//17
                                {"Constanta",44.1812, 28.4899},//18
                                {"Tulcea",45.1998, 28.7556},//19
                                {"Alba Iulia",46.0617,23.4879 },//20
                                {"Resita",45.3096,21.8690 },//21
                                {"Tirgu Jiu",45.0382,23.2125 },//22
                                {"Ramnicu Valcea",45.0964,24.3662 },//23
                                {"Drobeta Turnu Severin",44.6314,22.6497 },//24
                                {"Slatina",44.4360,24.3739 },//25
                                {"Pitesti",44.8671,24.8546 },//26
                                {"Targoviste",44.9189,25.4371 },//27
                                {"Alexandria",43.9741,25.3322 },//28
                                {"Giurgiu",43.8995,25.9577 },//29
                                {"Calarasi",44.2142,27.3068 },//30
                                {"Slobozia",44.5681,27.3548 },//31
                                {"Braila",45.3093, 27.9439},//32
                                {"Ploiesti",44.9343,26.0301 },//33
                                {"Buzau",45.1428,26.8104 },//34
                                {"Galati",45.4477,28.0351 },//35
                                {"Focsani",45.6993,27.1895 },//36
                                {"Brasov",45.6644,25.5823 },//37
                                {"Sfintu Gheorghe",45.8665,25.7988 },//38
                                {"Vaslui",46.6448, 27.7264},//39
                                {"Piatra Neamt",46.9339,26.3604 },//40
                                {"Botosani",47.7375,26.6243 },//41
                                {"Chisinau",46.9997,28.7180 }//42
        };

        static int[,] distance = { {0,62,90,0,0,0,0,133,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//1satumare
                                { 62,0,85,146,148,0,0,0,0,0,0,0,0,0,338,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//2baiamare
                                { 90,85,0,0,84,0,0,115,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//3zalau
                                {0,146,0,0,110,91 ,0,0,0,0,0,0,0,0,192,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//4bistrita
                                {0,148,84,110,0,111,0,152,0,0,0,0,0,0,0,0,0,0,0,99,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//5cluj
                                {0,0,0,91,111,0,139,0,0,0,0,115,0,0,0,0,0,0,0,120,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,170,0,0,0,0,0},//6tgmures
                                {0,0,0,0,0,139,0,0,0,0,0,0,0,0,235,0,139,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,100,68,0,137,0,0},//7Miercurea
                                {133,0,115,0,152,0,0,0,118,0,0,0,0,0,0,0,0,0,0,245,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//Oradea
                                {0,0,0,0,0,0,0,118,0,54,179,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//Arad
                                {0,0,0,0,0,0,0,0,54,0,148,0,0,0,0,0,0,0,0,0,97,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//Timisoara
                                {0,0,0,0,0,0,0,0,179,148,0,0,0,0,0,0,0,0,0,71,157,145,228,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//Deva
                                {0,0,0,0,0,115,0,0,0,0,0,0,0,0,0,0,0,0,0,77,0,0,97,0,0,155,0,0,0,0,0,0,0,0,0,0,142,0,0,0,0,0 },//Sibiu
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,109,126,112,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//Craiova
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,79,0,65,131,126,0,61,0,0,0,0,0,0,0,0,0 },//Bucuresti
                                {0,338,0,192,0,283,235,0,0,0,0,0,0,0,0,144,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,100,42,0 },//Suceava
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,144,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,66,129,109,154 },//Iasi
                                {0,0,0,0,0,0,139,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,184,0,0,153,100,61,0,0 },//Bacau
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,125,0,0,0,0,0,0,0,0,0,0,143,139,173,0,0,0,0,0,0,0,0,0,0 },//Constanta
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,125,0,0,0,0,0,0,0,0,0,0,0,0,0,94,0,0,83,0,0,0,0,0,0,0 },//Tulcea
                                {0,0,0,0,98,120,0,245,0,0,71,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//AlbaIulia
                                {0,0,0,0,0,0,0,0,0,97,157,0,0,0,0,0,0,0,0,0,0,225,0,159,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//resita
                                {0,0,0,0,0,0,0,0,0,0,145,0,109,0,0,0,0,0,0,0,225,0,113,96,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//tgjiu
                                {0,0,0,0,0,0,0,0,0,0,228,97,126,0,0,0,0,0,0,0,0,113,0,0,88,61,0,0,0,0,0,0,0,0,0,0,168,0,0,0,0,0 },//ramnicuv
                                {0,0,0,0,0,0,0,0,0,0,0,0,112,0,0,0,0,0,0,0,159,96,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//drobeta
                                {0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,88,0,0,71,0,104,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//slatina
                                {0,0,0,0,0,0,0,0,0,0,0,155,0,0,0,0,0,0,0,0,0,0,61,0,71,0,79,157,0,0,0,0,0,0,0,0,137,0,0,0,0,0, },//pitesti
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,79,0,0,0,0,0,0,0,0,0,0,0,79,0,138,166,0,0,0,49,0,0,0,125,0,0,0,0,0 },//targoviste
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,104,157,138,0,68,0,0,0,0,0,0,0,0,0,0,0,0,0 },//alexandria
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,65,0,0,0,0,0,0,0,0,0,0,0,0,166,68,0,189,0,0,0,0,0,0,0,0,0,0,0,0},//Giurgiu
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,131,0,0,0,143,0,0,0,0,0,0,0,0,0,0,189,0,45,0,0,0,0,0,0,0,0,0,0,0 },//calarasi
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,126,0,0,0,139,0,0,0,0,0,0,0,0,0,0,0,45,0,96,125,92,0,0,0,0,0,0,0,0 },//slobozia
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,173,94,0,0,0,0,0,0,0,0,0,0,0,96,0,0,104,22,90,0,0,0,0,0,0 },//braila
                                { 0,0,0,0,0,0,0,0,0,0,0,0,0,61,0,0,0,0,0,0,0,0,0,0,0,0,49,0,0,0,125,0,0,71,0,0,109,0,0,0,0,0},//ploiesti
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,92,104,71,0,0,72,159,155,0,0,0,0 },//buzau
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,83,0,0,0,0,0,0,0,0,0,0,0,0,22,0,0,0,88,0,0,161,0,0,0 },//galati
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,105,0,0,0,0,0,0,0,0,0,0,0,0,0,0,90,0,72,88,0,0,154,0,0,0,0 },//focsani
                                {0,0,0,0,0,170,100,0,0,0,0,142,0,0,0,0,0,0,0,0,0,0,0,0,0,137,125,0,0,0,0,0,109,159,0,0,0,35,0,0,0,0 },//brasov
                                {0,0,0,0,0,0,68,0,0,0,0,0,0,0,0,0,153,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,155,0,154,35,0,0,0,0,0 },//sfgheorghe
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,66,100,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,161,0,0,0,0,131,0,147 },//vaslui
                                {0,0,0,0,0,0,138,0,0,0,0,0,0,0,100,129,61,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,131,0,0,0 },//piatran
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,42,109,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,266 },//botosani
                                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,154,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,147,0,266,0 }//chisinau

        };

        static string[,] neighbours = { 
                                        {"Satu Mare","-","Baia Mare","Zalau","-","-","-","-","Oradea","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"  },
                                        {"Baia Mare","Satu Mare","-","Zalau","Bistrita","Cluj Napoca","-","-","-","-","-","-","-","-","Suceava","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Zalau","Satu Mare","Baia Mare","-","-","Cluj Napoca","-","-","Oradea","-","-","-","-","-","-","-","-" ,"-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                                        {"Bistrita","-","Baia Mare","-","-","Cluj Napoca","Targu Mures","-","-","-","-","-","-","-","-","Suceava","-","-","-","-","-","-","-" ,"-","-","-","-","-","-","-","-","-","-","-","-","-" ,"-","-","-","-","-","-","-"},
                                        {"Cluj Napoca","-","Baia Mare","Zalau","Bistrita","-","Targu Mures","-","Oradea","-","-","-","-","-","-","-","-","-","-","-","Alba Iulia","-","-","-","-","-","-","-" ,"-","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Targu Mures","-","-","-","Bistrita","Cluj Napoca","-","Miercurea Ciuc","-","-","-","-","Sibiu","-","-","Suceava","-","-","-","-","Alba Iulia","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Brasov","-","-","-","-","-" },
                                        {"Miercurea Ciuc","-","-","-","-","-","Targu Mures","-","-","-","-","-","-","-","-","Suceava","-","Bacau","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Brasov","Sfantu Gheorghe","-","Piatra Neamt","-","-" },
                                        {"Oradea","Satu Mare","-","Zalau","-","Cluj Napoca","-","-","-","Arad", "-","-","-","-","-","-","-","-","-","-","Alba Iulia","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                                        {"Arad","-","-","-","-","-","-","-","Oradea","-","Timisoara","Deva","-","-","-","-","-","-","-","-","-","-", "-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                                        {"Timisoara", "-","-","-","-","-","-","-","-","Arad","-","Deva","-","-","-","-","-","-","-","-","-","Resita","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                                        {"Deva","-","-","-","-","-","-","-","-","Arad","Timisoara","-","-","-","-","-","-","-","-","-","Alba Iulia","Resita","Targu Jiu","Ramnicu Valcea","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Sibiu","-","-","-","-","-","Targu Mures","-","-","-","-","-","-","-","-","-","-","-","-","-","Alba Iulia","-","-","Ramnicu Valcea","-","-","Pitesti","-","-","-","-","-","-","-","-","-","-","Brasov","-","-","-","-","-" },
                                        {"Craiova","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Targu Jiu","Ramnicu Valcea","Drobeta Turnu Severin","Slatina","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Bucuresti","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Targoviste","-","Giurgiu","Calarasi","Slobozia","-","Ploiesti","-","-","-","-","-","-","-","-","-" },
                                        {"Suceava","-","Baia Mare","-","Bistrita","-","Targu Mures","Miercurea Ciuc", "-","-","-","-","-","-","-","-","Iasi","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Piatra Neamt","Botosani","-"},
                                        {"Iasi","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Suceava","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Vaslui","Piatra Neamt","Botosani","Chisinau" },
                                        {"Bacau","-","-","-","-","-","-","Miercurea Ciuc","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Focsani","-","Sfantu Gheorghe","Vaslui","Piatra Neamt","-","-" },
                                        {"Constanta","-","-","-","-", "-","-","-","-","-","-","-","-","-","-","-","-","-","-","Tulcea","-","-","-","-","-","-","-","-","-","-","Calarasi","Slobozia","Braila","-","-","-","-","-","-","-","-","-","-"},
                                        {"Tulcea","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Constanta","-","-","-","-","-","-","-","-","-","-","-","-","-","Braila","-","-","Galati","-","-","-","-","-","-","-" },
                                        {"Alba Iulia","-","-","-","-","Cluj Napoca","Targu Mures","-","Oradea","-","-","Deva","Sibiu","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Resita","-","-","-","-","-","-","-","-","-","Timisoara","Deva","-","-","-","-","-","-","-","-","-","-","Targu Jiu","-","Drobeta Turnu Severin","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Targu Jiu","-","-","-","-","-","-","-","-","-","-","Deva","-","Craiova","-","-","-","-","-","-","-","Resita","-","Ramnicu Vlacea","Drobeta Turnu Severin","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Ramnicu Valcea","-","-","-","-","-","-","-","-","-","-","Deva","Sibiu","Craiova","-","-","-","-","-","-","-","-","Targu Jiu","-","-","Slatina","Pitesti","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Drobeta Turnu Severin","-","-","-","-","-","-","-","-","-","-","-","-","Craiova","-","-","-","-","-","-","-","Resita","Targu Jiu","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Slatina","-","-","-","-","-","-","-","-","-","-","-","-","Craiova","-","-","-","-","-","-","-","-","-","Ramnicu Valcea","-","-","Pitesti","-","Alexandria","-","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Pitesti","-","-","-","-","-","-","-","-","-","-","-","Sibiu","-","-","-","-","-","-","-","-","-","-","Ramnicu Valcea","-","Slatina","-","Targoviste","Alexandria","-","-","-","-","-","-","-","-","Brasov","-","-","-","-","-" },
                                        {"Targoviste","-","-","-","-","-","-","-","-","-","-","-","-","-","Bucuresti","-","-","-","-","-","-","-","-","-","-","-","Pitesti","-","Alexandria","Giurgiu","-","-","-","Ploiesti","-","-","-","Brasov","-","-","-","-","-" },
                                        {"Alexandria","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Slatina","Pitesti","Targoviste","-","Giurgiu","-","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Giurgiu","-","-","-","-","-","-","-","-","-","-","-","-","-","Bucuresti","-","-","-","-","-","-","-","-","-","-","-","-","Targoviste","Alexandria","-","Calarasi","-","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Calarasi","-","-","-","-","-","-","-","-","-","-","-","-","-","Bucuresti","-","-","-","Constanta","-","-","-","-","-","-","-","-","-","-","Giurgiu","-","Slobozia","-","-","-","-","-","-","-","-","-","-","-" },
                                        {"Slobozia","-","-","-","-","-","-","-","-","-","-","-","-","-","Bucuresti","-","-","-","Constanta","-","-","-","-","-","-","-","-","-","-","-","Calarasi","-","Braila","Ploiesti","Buzau","-","-","-","-","-","-","-","-" },
                                        {"Braila" ,"-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Constanta","Tulcea","-","-","-","-","-","-","-","-","-","-","-","Slobozia","-","-","Buzau","Galati","Focsani","-","-","-","-","-","-"},
                                        {"Ploiesti","-","-","-","-","-","-","-","-","-","-","-","-","-","Bucuresti","-","-","-","-","-","-","-","-","-","-","-","-","Targoviste","-","-","-","Slobozia","-","-","Buzau","-","-","Brasov","-","-","-","-","-"},
                                        {"Buzau","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Slobozia","Braila","Ploiesti","-","-","Focsani","Brasov","Sfantu Gheorghe","-","-","-","-" },
                                        {"Galati","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Tulcea","-","-","-","-","-","-","-","-","-","-","-","-","Braila","-","-","-","Focsani","-","-","Vaslui","-","-","-" },
                                        {"Focsani","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Bacau","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Braila","-","Buzau","Galati","-","-","Sfantu Gheorghe","-","-","-","-" },
                                        {"Brasov","-","-","-","-","-","Targu Mures","Miercurea Ciuc","-","-","-","-","Sibiu","-","-","-","-","-","-","-","-","-","-","-","-","-","Pitesti","Targoviste","-","-","-","-","-","Ploiesti","Buzau","-","-","-","Sfantu Gheorghe","-","-","-","-" },
                                        {"Sfantu Gheorghe","-","-","-","-","-","-","Miercurea Ciuc","-","-","-","-","-","-","-","-","-","Bacau","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Buzau","-","Focsani","Brasov","-","-","-","-","-"},
                                        {"Vaslui","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Iasi","Bacau","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Galati","-","-","-","-","Piatra Neamt","-","Chisinau"},
                                        {"Piatra Neamt","-","-","-","-","-","-","Miercurea Ciuc","-","-","-","-","-","-","-","Suceava","Iasi","Bacau","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Vaslui","-","-","-"},
                                        {"Botosani","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Suceava","Iasi","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Chisinau"},
                                        {"Chisinau","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Iasi","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","Vaslui","-","Botosani","-"}

    };

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void SatuMare_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Satu Mare";
            }
            else if (textBoxSursa.Text == "Satu Mare")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Satu Mare";
            }
        }

        private void Botosani_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Botosani";
            }
            else if (textBoxSursa.Text == "Botosani")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Botosani";
            }
        }

        private void Iasi_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Iasi";
            }
            else if (textBoxSursa.Text == "Iasi")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Iasi";
            }
        }

        private void Piatra_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Piatra Neamt";
            }
            else if (textBoxSursa.Text == "Piatra Neamt")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Piatra Neamt";
            }
        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {

        }

        private void Bacau_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Bacau";
            }
            else if (textBoxSursa.Text == "Bacau")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Bacau";
            }
        }

        private void TarguMures_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Targu Mures";
            }
            else if (textBoxSursa.Text == "Targu Mures")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Targu Mures";
            }
        }

        private void Arad_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Arad";
            }
            else if (textBoxSursa.Text == "Arad")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Arad";
            }
        }

        private void Oradea_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Oradea";
            }
            else if (textBoxSursa.Text == "Oradea")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Oradea";
            }
        }

        private void BaiaMare_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Baia Mare";
            }
            else if (textBoxSursa.Text == "Baia Mare")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Baia Mare";
            }
        }

        private void Zalau_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Zalau";
            }
            else if (textBoxSursa.Text == "Zalau")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Zalau";
            }
        }

        private void Chisinau_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Chisinau";
            }
            else if (textBoxSursa.Text == "Chisinau")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Chisinau";
            }
        }

        private void Slatina_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Slatina";
            }
            else if (textBoxSursa.Text == "Slatina")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Slatina";
            }
        }

        private void Bucuresti_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Bucuresti";
            }
            else if (textBoxSursa.Text == "Bucuresti")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Bucuresti";
            }
        }

        private void Pitesti_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Pitesti";
            }
            else if (textBoxSursa.Text == "Pitesti")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Pitesti";
            }
        }

        private void TgJiu_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Targu Jiu";
            }
            else if (textBoxSursa.Text == "Targu Jiu")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Targu Jiu";
            }
        }

        private void Braila_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Braila";
            }
            else if (textBoxSursa.Text == "Braila")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Braila";
            }
        }

        private void Tulcea_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Tulcea";
            }
            else if (textBoxSursa.Text == "Tulcea")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Tulcea";
            }
        }

        private void Buzau_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Buzau";
            }
            else if (textBoxSursa.Text == "Buzau")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Buzau";
            }
        }

        private void Galati_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Galati";
            }
            else if (textBoxSursa.Text == "Galati")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Galati";
            }
        }

        private void Vaslui_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Vaslui";
            }
            else if (textBoxSursa.Text == "Vaslui")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Vaslui";
            }
        }

        private void Suceava_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Suceava";
            }
            else if (textBoxSursa.Text == "Suceava")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Suceava";
            }
        }

        private void MiercureaCiuc_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Miercurea Ciuc";
            }
            else if (textBoxSursa.Text == "Miercurea Ciuc")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Miercurea Ciuc";
            }
        }

        private void SfGheorghe_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Miercurea Ciuc";
            }
            else if (textBoxSursa.Text == "Miercurea Ciuc")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Miercurea Ciuc";
            }
        }

        private void Focsani_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Focsani";
            }
            else if (textBoxSursa.Text == "Focsani")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Focsani";
            }
        }

        private void Slobozia_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Slobozia";
            }
            else if (textBoxSursa.Text == "Slobozia")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Slobozia";
            }
        }

        private void Ploiesti_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Ploiesti";
            }
            else if (textBoxSursa.Text == "Ploiesti")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Ploiesti";
            }
        }

        private void Brasov_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Brasov";
            }
            else if (textBoxSursa.Text == "Brasov")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Brasov";
            }
        }

        private void Targoviste_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Targoviste";
            }
            else if (textBoxSursa.Text == "Targoviste")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Targoviste";
            }
        }

        private void RamnicuValcea_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Ramnicu Valcea";
            }
            else if (textBoxSursa.Text == "Ramnicu Valcea")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Ramnicu Valcea";
            }
        }

        private void Resita_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Resita";
            }
            else if (textBoxSursa.Text == "Resita")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Resita";
            }
        }

        private void Drobeta_Click (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Drobeta Turnu Severin";
            }
            else if (textBoxSursa.Text == "Drobeta Turnu Severin")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Drobeta Turnu Severin";
            }
        }

        private void Timisoara_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Timisoara";
            }
            else if (textBoxSursa.Text == "Timisoara")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Timisoara";
            }
        }

        private void Deva_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Deva";
            }
            else if (textBoxSursa.Text == "Deva")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Deva";
            }
        }
        private void Ruta_Click (object sender, EventArgs e)
    {

    }

        private void Sibiu_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Sibiu";
            }
            else if (textBoxSursa.Text == "Sibiu")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Sibiu";
            }
        }

        private void AlbaIulia_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Alba Iulia";
            }
            else if (textBoxSursa.Text == "Alba Iulia")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Alba Iulia";
            }
        }

        private void Cluj_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Cluj Napoca";
            }
            else if (textBoxSursa.Text == "Cluj Napoca")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Cluj Napoca";
            }
        }

        private void Bistrita_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Bistrita";
            }
            else if (textBoxSursa.Text == "Bistrita")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Bistrita";
            }
        }

        private void Craiova_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Craiova";
            }
            else if (textBoxSursa.Text == "Craiova")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Craiova";
            }
        }

        private void Alexandria_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Alexandria";
            }
            else if (textBoxSursa.Text == "Alexandria")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Alexandria";
            }
        }

        private void Giurgiu_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Giurgiu";
            }
            else if (textBoxSursa.Text == "Giurgiu")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Giurgiu";
            }
        }

        private void Calarasi_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Calarasi";
            }
            else if (textBoxSursa.Text == "Calarasi")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Calarasi";
            }
        }

        private void Constanta_Click (object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSursa.Text) && !String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                System.Windows.Forms.MessageBox.Show("Valorile au fost deja selectate.");
            }
            else if (String.IsNullOrEmpty(textBoxSursa.Text))
            {
                textBoxSursa.Text = "Constanta";
            }
            else if (textBoxSursa.Text == "Constanta")
            {
                System.Windows.Forms.MessageBox.Show("Te rog, selecteaza un oras diferit de punctul de plecare!");
            }
            else if (String.IsNullOrEmpty(textBoxDestinatie.Text))
            {
                textBoxDestinatie.Text = "Constanta";
            }
        }

        private void textBoxSursa_TextChanged (object sender, EventArgs e)
        {
        }

        private void Calculeaza_Click (object sender, EventArgs e)
        {
            string a = (string)textBoxSursa.Text;
            string b = (string)textBoxDestinatie.Text;
            alg(a, b);
        }

        private void Sterge_Click (object sender, EventArgs e)
        {
            textBoxSursa.Text = "";
            textBoxDestinatie.Text = "";
            textBoxRuta.Text = "";
        }

        private void textBoxDestinatie_TextChanged (object sender, EventArgs e)
        {

        }

        private void textBoxKm_TextChanged (object sender, EventArgs e)
        {

        }

        private void textBoxRuta_TextChanged (object sender, EventArgs e)
        {

        }

        private double deg2rad (double deg)
        {
            double pi = 3.1415926535897932384626433832795;
            return deg * pi / 180.0;
        }

        private double euristica (double sursa_latitudine, double sursa_longitudine, double destinatie_latitudine, double destinatie_longitudine)
        {
            double lat1 = deg2rad(sursa_latitudine);
            double lat2 = deg2rad(destinatie_latitudine);
            double long1 = deg2rad(sursa_longitudine);
            double long2 = deg2rad(destinatie_longitudine);

            double d_long = (sursa_longitudine - destinatie_longitudine) * (3.14 / 180);
            double d_lat = (sursa_latitudine - destinatie_latitudine) * (3.14 / 180);
            double d2r = 3.14 / 180;
            double a = Math.Pow(Math.Sin(d_lat / 2.0), 2) + Math.Cos(lat1 * d2r) * Math.Cos(lat2 * d2r) * Math.Pow(Math.Sin(d_long / 2.0), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = 6367 * c;
            return d;
        }

        private void alg (string start1, string goal)
        {
            string start = start1;
            string duplicate_goal = goal;
            int i = 0;
            double dist = 0;
            string oras = "\t";
            double min = 0;
            double cost = 0;
            double latitudine1 = 0;
            double longitudine1 = 0;
            double latitudine2 = 0;
            double longitudine2 = 0;
            double latitudine3 = 0;
            double longitudine3 = 0;
            double latitudine4 = 0;
            double longitudine4 = 0;
            int found = 0;

            List<string> closed = new List<string>();
            List<string> closed_duplicate = new List<string>();

            List<string> path = new List<string>();
            List<string> path_duplicate = new List<string>();

            path.Add(start);
            path_duplicate.Add(duplicate_goal);

            for (int t = 0; t <= 41; t++)
            {
                if (goal == (string)rel[t, 0])
                {
                    latitudine2 = System.Convert.ToDouble(rel[t, 1]);
                    longitudine2 = System.Convert.ToDouble(rel[t, 2]);
                    break;
                }
            }
            for (int t = 0; t <= 41; t++)
            {
                if (start == (string)rel[t, 0])
                {
                    latitudine3 = System.Convert.ToDouble(rel[t, 1]);
                    longitudine3 = System.Convert.ToDouble(rel[t, 2]);
                    break;
                }
            }
            while (found == 0)
            {
                for (i = 0; i <= 41; i++)
                {
                    if (neighbours[i, 0] == start)
                    {
                        string[] aux = { "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t","\t","\t" };
                        closed.Add(start);
                        for (int t = 0; t <= 41; t++)
                        {
                            if (start == (string)rel[t, 0])
                            {

                                Console.Write("\n-----------------------------------------------------\n");
                                Console.Write("(De la start)Vecinii orasului {0} sunt- noduri prin care nu s-a trecut:\n", start);
                                break;
                            }
                        }
                        for (int k = 1; k <= 42; k++)
                        {

                            aux[k - 1] = neighbours[i, k];

                            if (aux[k - 1] != "-" && !closed.Contains(aux[k - 1]))
                            {
                                for (int t = 0; t <= 41; t++)
                                {
                                    string a = path.Last();
                                    for (int q = 0; q <= 41; q++)
                                    {
                                        if (a == (string)rel[q, 0])
                                        {
                                            latitudine4 = System.Convert.ToDouble(rel[q, 1]);
                                            longitudine4 = System.Convert.ToDouble(rel[q, 2]);
                                            break;
                                        }
                                    }
                                    if (aux[k - 1] == (string)rel[t, 0])
                                    {
                                        latitudine1 = System.Convert.ToDouble(rel[t, 1]);
                                        longitudine1 = System.Convert.ToDouble(rel[t, 2]);
                                        double g = euristica(latitudine1, longitudine1, latitudine2, longitudine2);

                                        dist = distance[i, k - 1];
                                        cost = g + dist/2;

                                        Console.Write("\nValoarea costului pentru {0} este {1}.\n", aux[k - 1], cost);
                                        if (min == 0)
                                        {
                                            min = cost;
                                            oras = aux[k - 1];
                                        }
                                        else if (min > cost)
                                        {
                                            min = cost;
                                            oras = aux[k - 1];
                                        }
                                        else if (!closed.Contains(aux[k - 1]))
                                        {
                                            closed.Add(aux[k - 1]);
                                        }
                                    }
                                }
                            }
                        }
                        
                        if (!path.Contains(oras) && !closed.Contains(oras))
                        {
                            path.Add(oras);
                        }
                        min = 0;
                        start = oras;
                    
                        foreach (string item in path)
                        {
                            if (path_duplicate.Contains(item))
                                found = 1;
                            else if (path_duplicate.Contains(start1) || path_duplicate.Contains(start))
                                found = 1;
                            else if (path.Contains(goal) || path.Contains(duplicate_goal))
                                found = 1;
                        }

                        if (found == 1)
                        {
                            path_duplicate.Reverse();
                            foreach (string item in path_duplicate)
                            {
                                if (!path.Contains(item))
                                {
                                    path.Add(item);
                                }
                            }

                            Console.Write("\nCale:\n");
                            string item1 = "";
                            foreach (string item in path)
                                item1 += item + "\n";

                            Console.Write("{0}\n", item1);
                            textBoxRuta.Text = item1.Replace("\n", Environment.NewLine);
                            break;
                            
                        }

                        else
                        {
                            for (i = 0; i <= 41; i++)
                            {
                                if (neighbours[i, 0] == duplicate_goal)
                                {
                                    string[] aux1 = { "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t", "\t" };
                                    closed_duplicate.Add(duplicate_goal);


                                    for (int t = 0; t <= 41; t++)
                                    {
                                        if (duplicate_goal == (string)rel[t, 0])
                                        {

                                            Console.Write("\n-----------------------------------------------------\n");
                                            Console.Write("(De la destinatie)Vecinii orasului {0} sunt:\n", duplicate_goal);
                                            break;
                                        }
                                    }

                                    for (int k = 1; k <= 42; k++)
                                    {
                                        aux1[k - 1] = neighbours[i, k];
                                        if (aux1[k - 1] != "-" && !closed_duplicate.Contains(aux1[k - 1]))

                                        {
                                            for (int t = 0; t <= 41; t++)
                                            {
                                                string a = path_duplicate.Last();
                                                for (int q = 0; q <= 41; q++)
                                                {
                                                    if (a == (string)rel[q, 0])
                                                    {
                                                        latitudine4 = System.Convert.ToDouble(rel[q, 1]);
                                                        longitudine4 = System.Convert.ToDouble(rel[q, 2]);
                                                        break;
                                                    }
                                                }
                                                if (aux1[k - 1] == (string)rel[t, 0])
                                                {
                                                    latitudine1 = System.Convert.ToDouble(rel[t, 1]);
                                                    longitudine1 = System.Convert.ToDouble(rel[t, 2]);
                                                    double g = euristica(latitudine1, longitudine1, latitudine3, longitudine3);
                                                    dist = distance[i, k - 1];
                                                    cost = g + dist/2;

                                                    Console.Write("Valoarea costului pentru {0} este {1}.\n", aux1[k - 1], cost);
                                                    if (min == 0)
                                                    {
                                                        min = cost;
                                                        oras = aux1[k - 1];
                                                    }
                                                    else if (min > cost)
                                                    {
                                                        min = cost;
                                                        oras = aux1[k - 1];
                                                    }
                                                    else if (!closed_duplicate.Contains(aux1[k - 1]))

                                                    {
                                                        closed_duplicate.Add(aux1[k - 1]);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                    
                                    if (!path_duplicate.Contains(oras) && !closed_duplicate.Contains(oras))
                                    {
                                        path_duplicate.Add(oras);
                                    }
                                    min = 0;
                                    duplicate_goal = oras;
                                }
                            
                                foreach (string item in path_duplicate)
                                {
                                    if (path.Contains(item))
                                        found = 1;
                                    else if (path_duplicate.Contains(start1) || path_duplicate.Contains(start))
                                        found = 1;
                                    else if (path.Contains(goal) || path.Contains(duplicate_goal))
                                        found = 1;
                                }
                                if (found == 1)
                                {
                                    path_duplicate.Reverse();

                                    foreach (string item in path_duplicate)
                                    {
                                        if (!path.Contains(item))
                                        {
                                            path.Add(item);
                                        }
                                    }

                                    Console.Write("\nCale:\n");
                                    string item1 = "";
                                    foreach (string item in path)
                                        item1 += item + "\n";

                                    Console.Write("{0}\n", item1);
                                    textBoxRuta.Text = item1.Replace("\n", Environment.NewLine);
                                    goto Found;

                                   
                                }
                            Found:
                                break;

                            }
                        }
                    }
                }
            }
        
        }
    }
}

