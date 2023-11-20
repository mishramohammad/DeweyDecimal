using System;
using System.Collections.Generic;
using System.Text;

namespace DeweySystem.FindCalls
{
    public class CreateTree
    {

        FindCalls.FindCallNoList fcn = new FindCalls.FindCallNoList();

        public void makeTree()
        {
            Tree<CallNumbers> tree = new Tree<CallNumbers>();
            tree.Root = new TreeNode<CallNumbers>() { Data = new CallNumbers("Dewey", "Dewey") };

            //1st level

            tree.Root.Children = new List<TreeNode<CallNumbers>>
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("000", "Generalities"), Parent = tree.Root},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("100", "Philosophy & Psychology"), Parent = tree.Root},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("200", "Religion"), Parent = tree.Root},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("300", "Social Sciences"), Parent = tree.Root},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("400", "Language"), Parent = tree.Root},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("500", "Science"), Parent = tree.Root},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("600", "Technology"), Parent = tree.Root},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("700", "Arts & Recreation"), Parent = tree.Root},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("800", "Literature"), Parent = tree.Root},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("900", "History & Geography"), Parent = tree.Root}
            };

            //2nd level
            tree.Root.Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("010", "Bibliography"), Parent = tree.Root.Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("030", "General encyclopedic works"), Parent = tree.Root.Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("050", "General serials & their indexes"), Parent = tree.Root.Children[0]}
            };

            tree.Root.Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("110", "Metaphysics"), Parent = tree.Root.Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("150", "Psychology"), Parent = tree.Root.Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("180", "Ancient, medieval, Oriental philosophy"), Parent = tree.Root.Children[1]}
            };

            tree.Root.Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("210", "Philosophy and theory of religion"), Parent = tree.Root.Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("280", "Christian denominations & sects"), Parent = tree.Root.Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("290", "Other & comparative religions"), Parent = tree.Root.Children[2] }
            };

            tree.Root.Children[3].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("310", "Statistics"), Parent = tree.Root.Children[3]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("320", "Political Science"), Parent = tree.Root.Children[3]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("370", "Education"), Parent = tree.Root.Children[3]}
            };

            tree.Root.Children[4].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("410", "Linguistics"), Parent = tree.Root.Children[4]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("450", "Italian, Romanian, and related languages"), Parent = tree.Root.Children[4]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("470", "Italic Latin"), Parent = tree.Root.Children[4]}
            };

            tree.Root.Children[5].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("510", "Mathematics"), Parent = tree.Root.Children[5]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("530", "Physics"), Parent = tree.Root.Children[5]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("580", "Botanical sciences"), Parent = tree.Root.Children[5]}
            };

            tree.Root.Children[6].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("640", "Home economics & family living"), Parent = tree.Root.Children[6]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("650", "Management & auxiliary services"), Parent = tree.Root.Children[6]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("660", "Chemical engineering"), Parent = tree.Root.Children[6]}
            };

            tree.Root.Children[7].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("710", "Civic & landscape art"), Parent = tree.Root.Children[7]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("730", "Plastic arts Sculpture"), Parent = tree.Root.Children[7]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("770", "Photography & photographs"), Parent = tree.Root.Children[7]}
            };

            tree.Root.Children[8].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("840", "Literatures of Romance languages"), Parent = tree.Root.Children[8]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("860", "Spanish & Portuguese literatures"), Parent = tree.Root.Children[8]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("870", "General works on Latin literature"), Parent = tree.Root.Children[8]}
            };

            tree.Root.Children[9].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("910", "Geography & travel"), Parent = tree.Root.Children[9]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("950", "General history of Asia Far East"), Parent = tree.Root.Children[9]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("990", "General history of other areas"), Parent = tree.Root.Children[9]}
            };

            //THIRD-LEVEL NODES

            //010
            tree.Root.Children[0].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("011", "Bibliographies"), Parent = tree.Root.Children[0].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("019", "Dictionary catalogs"), Parent = tree.Root.Children[0].Children[0]}
            };

            //030
            tree.Root.Children[0].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("032", "General encyclopedic works in English"), Parent = tree.Root.Children[0].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("038", "General encyclopedic works in Scandinavian languages"), Parent = tree.Root.Children[0].Children[1]}
            };

            //050
            tree.Root.Children[0].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("056", "General serials & their indexes In Spanish"), Parent = tree.Root.Children[0].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("057", "General serials & their indexes In Slavic languages"), Parent = tree.Root.Children[0].Children[2]}
            };

            //110
            tree.Root.Children[1].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("111", "Ontology"), Parent = tree.Root.Children[1].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("113", "Cosmology (Philosophy of nature)"), Parent = tree.Root.Children[1].Children[0]}
            };

            //150
            tree.Root.Children[1].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("153", "Mental processes & intelligence"), Parent = tree.Root.Children[1].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("156", "Comparative psychology"), Parent = tree.Root.Children[1].Children[1]}
            };

            //180
            tree.Root.Children[1].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("181", "Oriental philosophy"), Parent = tree.Root.Children[1].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("184", "Platonic philosophy"), Parent = tree.Root.Children[1].Children[2]}
            };

            //210
            tree.Root.Children[2].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("214", "Theodicy"), Parent = tree.Root.Children[2].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("215", "Science & Religion"), Parent = tree.Root.Children[2].Children[0]}
            };

            //280
            tree.Root.Children[2].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("281", "Early church & Eastern churches"), Parent = tree.Root.Children[2].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("287", "Methodist & related churches"), Parent = tree.Root.Children[2].Children[1]}
            };

            //290
            tree.Root.Children[2].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("291", "Comparative religion"), Parent = tree.Root.Children[2].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("294", "Religions of Indic origin"), Parent = tree.Root.Children[2].Children[2]}
            };


            //310
            tree.Root.Children[3].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("314", "General statistics Of Europe"), Parent = tree.Root.Children[3].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("315", "General statistics Of Asia"), Parent = tree.Root.Children[3].Children[0]}
            };

            //320
            tree.Root.Children[3].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("325", "International migration & colonization"), Parent = tree.Root.Children[3].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("328", "The legislative process"), Parent = tree.Root.Children[3].Children[1]}
            };

            //370
            tree.Root.Children[3].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("372", "Elementary education"), Parent = tree.Root.Children[3].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("375", "Curriculums"), Parent = tree.Root.Children[3].Children[2]}
            };

            //410
            tree.Root.Children[4].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("414", "Phonology"), Parent = tree.Root.Children[4].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("415", "Structural systems (Grammar)"), Parent = tree.Root.Children[4].Children[0]}
            };

            //450
            tree.Root.Children[4].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("451", "Italian writing system & phonology"), Parent = tree.Root.Children[4].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("452", "Italian etymology"), Parent = tree.Root.Children[4].Children[1]}
            };

            //470
            tree.Root.Children[4].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("471", "Classical Latin writing & phonology"), Parent = tree.Root.Children[4].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("473", "Classical Latin dictionaries"), Parent = tree.Root.Children[4].Children[2]}
            };

            //510
            tree.Root.Children[5].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("514", "Topology"), Parent = tree.Root.Children[5].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("515", "Analysis"), Parent = tree.Root.Children[5].Children[0]}
            };

            //530
            tree.Root.Children[5].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("531", "Classical mechanics Solid mechanics"), Parent = tree.Root.Children[5].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("533", "Gas mechanics"), Parent = tree.Root.Children[5].Children[1]}
            };

            //580
            tree.Root.Children[5].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("581", "Botany"), Parent = tree.Root.Children[5].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("588", "Bryophyta"), Parent = tree.Root.Children[5].Children[2]}
            };

            //640
            tree.Root.Children[6].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("643", "Housing & household equipment"), Parent = tree.Root.Children[6].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("644", "Household utilities"), Parent = tree.Root.Children[6].Children[0]}
            };

            //650
            tree.Root.Children[6].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("651", "Office services"), Parent = tree.Root.Children[6].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("653", "Shorthand"), Parent = tree.Root.Children[6].Children[1]}
            };

            //660
            tree.Root.Children[6].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("663", "Beverage technology"), Parent = tree.Root.Children[6].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("664", "Food technology"), Parent = tree.Root.Children[6].Children[2]}
            };

            //710
            tree.Root.Children[7].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("713", "Landscape architecture of trafficways"), Parent = tree.Root.Children[7].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("714", "Water features"), Parent = tree.Root.Children[7].Children[0]}
            };

            //730
            tree.Root.Children[7].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("733", "Greek, Etruscan, Roman sculpture"), Parent = tree.Root.Children[7].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("736", "Carving & carvings"), Parent = tree.Root.Children[7].Children[1]}
            };

            //770
            tree.Root.Children[7].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("772", "Metallic salt processes"), Parent = tree.Root.Children[7].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("773", "Pigment processes of printing"), Parent = tree.Root.Children[7].Children[2]}
            };

            //840
            tree.Root.Children[8].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("847", "French Canadian"), Parent = tree.Root.Children[8].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("848", "Provencal"), Parent = tree.Root.Children[8].Children[0]}
            };

            //860
            tree.Root.Children[8].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("864", "1700-1800"), Parent = tree.Root.Children[8].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("867", "Catalan"), Parent = tree.Root.Children[8].Children[1]}
            };

            //870
            tree.Root.Children[8].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("871", "Latin Authors"), Parent = tree.Root.Children[8].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("872", "Collections of Latin prose or poetry"), Parent = tree.Root.Children[8].Children[2]}
            };

            //910
            tree.Root.Children[9].Children[0].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("911", "Historical geography"), Parent = tree.Root.Children[9].Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("913", "Ancient world"), Parent = tree.Root.Children[9].Children[0]}
            };

            //950
            tree.Root.Children[9].Children[1].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("952", "General history of Asia Japan"), Parent = tree.Root.Children[9].Children[1]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("954", "General history of Asia South Asia India"), Parent = tree.Root.Children[9].Children[1]}
            };

            //990
            tree.Root.Children[9].Children[2].Children = new List<TreeNode<CallNumbers>>()
            {
                new TreeNode<CallNumbers>(){Data = new CallNumbers("993", "General history of other areas New Zealand"), Parent = tree.Root.Children[9].Children[2]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("995", "General history of other areas Melanesia New Guinea"), Parent = tree.Root.Children[9].Children[2]}
            };
        }
    }
}

//Kini, M. 2020. Tree data structure. [Online]. [Accessed: 20 November 2023].
//reference: https://www.c-sharpcorner.com/article/tree-data-structure/