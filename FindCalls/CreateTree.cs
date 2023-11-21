using System;
using System.Collections.Generic;
using System.Text;

namespace DeweySystem.FindCalls
{
    public class CreateTree
    {
        public CallNumbers Create()
        {
            var root = new CallNumbers("Dewey", "Dewey");
            MakeTree(root);
            return root;
        }

        private void MakeTree(CallNumbers root)
        {
            root.Children = new List<CallNumbers>
            {
                // FIRST LEVEL
                new CallNumbers("000", "Generalities"),
                new CallNumbers("100", "Philosophy & Psychology"),
                new CallNumbers("200", "Religion"),
                new CallNumbers("300", "Social Sciences"),
                new CallNumbers("400", "Language"),
                new CallNumbers("500", "Science"),
                new CallNumbers("600", "Technology"),
                new CallNumbers("700", "Arts & Recreation"),
                new CallNumbers("800", "Literature"),
                new CallNumbers("900", "History & Geography")
            };

            // SECOND LEVEL
            root.Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("010", "Bibliography"),
                new CallNumbers("030", "General encyclopedic works"),
                new CallNumbers("050", "General serials & their indexes")
            };

            root.Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("110", "Metaphysics"),
                new CallNumbers("150", "Psychology"),
                new CallNumbers("180", "Ancient, medieval, Oriental philosophy")
            };

            root.Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("210", "Philosophy and theory of religion"),
                new CallNumbers("280", "Christian denominations & sects"),
                new CallNumbers("290", "Other & comparative religions")
            };

            root.Children[3].Children = new List<CallNumbers>
            {
                new CallNumbers("310", "Statistics"),
                new CallNumbers("320", "Political Science"),
                new CallNumbers("370", "Education")
            };

            root.Children[4].Children = new List<CallNumbers>
            {
                new CallNumbers("410", "Linguistics"),
                new CallNumbers("450", "Italian, Romanian, and related languages"),
                new CallNumbers("470", "Italic Latin")
            };

            root.Children[5].Children = new List<CallNumbers>
            {
                new CallNumbers("510", "Mathematics"),
                new CallNumbers("530", "Physics"),
                new CallNumbers("580", "Botanical sciences")
            };

            root.Children[6].Children = new List<CallNumbers>
            {
                new CallNumbers("640", "Home economics & family living"),
                new CallNumbers("650", "Management & auxiliary services"),
                new CallNumbers("660", "Chemical engineering")
            };

            root.Children[7].Children = new List<CallNumbers>
            {
                new CallNumbers("710", "Civic & landscape art"),
                new CallNumbers("730", "Plastic arts Sculpture"),
                new CallNumbers("770", "Photography & photographs")
            };

            root.Children[8].Children = new List<CallNumbers>
            {
                new CallNumbers("840", "Literatures of Romance languages"),
                new CallNumbers("860", "Spanish & Portuguese literatures"),
                new CallNumbers("870", "General works on Latin literature")
            };

            root.Children[9].Children = new List<CallNumbers>
            {
                new CallNumbers("910", "Geography & travel"),
                new CallNumbers("950", "General history of Asia Far East"),
                new CallNumbers("990", "General history of other areas")
            };

            // THIRD-LEVEL NODES

            // 010
            root.Children[0].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("011", "Bibliographies"),
                new CallNumbers("019", "Dictionary catalogs")
            };

            // 030
            root.Children[0].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("032", "General encyclopedic works in English"),
                new CallNumbers("038", "General encyclopedic works in Scandinavian languages")
            };

            // 050
            root.Children[0].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("056", "General serials & their indexes In Spanish"),
                new CallNumbers("057", "General serials & their indexes In Slavic languages")
            };

            // 110
            root.Children[1].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("111", "Ontology"),
                new CallNumbers("113", "Cosmology (Philosophy of nature)")
            };

            // 150
            root.Children[1].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("153", "Mental processes & intelligence"),
                new CallNumbers("156", "Comparative psychology")
            };

            // 180
            root.Children[1].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("181", "Oriental philosophy"),
                new CallNumbers("184", "Platonic philosophy")
            };

            // 210
            root.Children[2].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("214", "Theodicy"),
                new CallNumbers("215", "Science & Religion")
            };

            // 280
            root.Children[2].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("281", "Early church & Eastern churches"),
                new CallNumbers("287", "Methodist & related churches")
            };

            // 290
            root.Children[2].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("291", "Comparative religion"),
                new CallNumbers("294", "Religions of Indic origin")
            };

            // 310
            root.Children[3].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("314", "General statistics Of Europe"),
                new CallNumbers("315", "General statistics Of Asia")
            };

            // 320
            root.Children[3].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("325", "International migration & colonization"),
                new CallNumbers("328", "The legislative process")
            };

            // 370
            root.Children[3].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("372", "Elementary education"),
                new CallNumbers("375", "Curriculums")
            };

            // 410
            root.Children[4].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("414", "Phonology"),
                new CallNumbers("415", "Structural systems (Grammar)")
            };

            // 450
            root.Children[4].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("451", "Italian writing system & phonology"),
                new CallNumbers("452", "Italian etymology")
            };

            // 470
            root.Children[4].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("471", "Classical Latin writing & phonology"),
                new CallNumbers("473", "Classical Latin dictionaries")
            };

            // 510
            root.Children[5].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("514", "Topology"),
                new CallNumbers("515", "Analysis")
            };

            // 530
            root.Children[5].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("531", "Classical mechanics Solid mechanics"),
                new CallNumbers("533", "Gas mechanics")
            };

            // 580
            root.Children[5].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("581", "Botany"),
                new CallNumbers("588", "Bryophyta")
            };

            // 640
            root.Children[6].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("643", "Housing & household equipment"),
                new CallNumbers("644", "Household utilities")
            };

            // 650
            root.Children[6].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("651", "Office services"),
                new CallNumbers("653", "Shorthand")
            };

            // 660
            root.Children[6].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("663", "Beverage technology"),
                new CallNumbers("664", "Food technology")
            };

            // 710
            root.Children[7].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("713", "Landscape architecture of trafficways"),
                new CallNumbers("714", "Water features")
            };

            // 730
            root.Children[7].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("733", "Greek, Etruscan, Roman sculpture"),
                new CallNumbers("736", "Carving & carvings")
            };

            // 770
            root.Children[7].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("772", "Metallic salt processes"),
                new CallNumbers("773", "Pigment processes of printing")
            };

            // 840
            root.Children[8].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("847", "French Canadian"),
                new CallNumbers("848", "Provencal")
            };

            // 860
            root.Children[8].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("864", "1700-1800"),
                new CallNumbers("867", "Catalan")
            };

            // 870
            root.Children[8].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("871", "Latin Authors"),
                new CallNumbers("872", "Collections of Latin prose or poetry")
            };

            // 910
            root.Children[9].Children[0].Children = new List<CallNumbers>
            {
                new CallNumbers("911", "Historical geography"),
                new CallNumbers("913", "Ancient world")
            };

            // 950
            root.Children[9].Children[1].Children = new List<CallNumbers>
            {
                new CallNumbers("952", "General history of Asia Japan"),
                new CallNumbers("954", "General history of Asia South Asia India")
            };

            // 990
            root.Children[9].Children[2].Children = new List<CallNumbers>
            {
                new CallNumbers("993", "General history of other areas New Zealand"),
                new CallNumbers("995", "General history of other areas Melanesia New Guinea")
            };
        }
    }
}

//Kini, M. 2020. Tree data structure. [Online]. [Accessed: 20 November 2023].
//reference: https://www.c-sharpcorner.com/article/tree-data-structure/

//reference: University Library. 2023. Information sciences virtual library. [Blog]. [Accessed: 20 November 2023]
//reference: https://www.library.illinois.edu/infosci/research/guides/dewey/