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
                new TreeNode<CallNumbers>(){Data = new CallNumbers("003", "Systems"), Parent = tree.Root.Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("004", "Data processing Computer science"), Parent = tree.Root.Children[0]},
                new TreeNode<CallNumbers>(){Data = new CallNumbers("006", "Special computer methods"), Parent = tree.Root.Children[0]}
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

            //3rd level

            tree.Root.Children[0].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                        
            {                                                                                                                              
                new TreeNode<CallNumbers>(){Data = new CallNumbers("111", "Ontology"), Parent = tree.Root.Children[0].Children[0]},                                 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("113", "Cosmology"), Parent = tree.Root.Children[0].Children[0]},                           
                new TreeNode<CallNumbers>(){Data = new CallNumbers("114", "Space"), Parent = tree.Root.Children[0].Children[0]}                               
            };

            tree.Root.Children[0].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                      
            {                                                                                                                                
                new TreeNode<CallNumbers>(){Data = new CallNumbers("121", "Epistemology (Theory of knowledge)"), Parent = tree.Root.Children[0].Children[1]},       
                new TreeNode<CallNumbers>(){Data = new CallNumbers("122", "Causation"), Parent = tree.Root.Children[0].Children[1]},                                 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("123", "Determinism and indeterminism"), Parent = tree.Root.Children[0].Children[1]}             
            };

            tree.Root.Children[0].Children[2].Children = new List<TreeNode<CallNumbers>>()                                                                                               
            {                                                                                                                                                                      
                new TreeNode<CallNumbers>(){Data = new CallNumbers("131", "Parapsychological and occult methods for achieving well-being, happiness, success"), Parent = tree.Root.Children[0].Children[2]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("133", "Specific topics in parapsychology and occultism"), Parent = tree.Root.Children[0].Children[2]},                                   
                new TreeNode<CallNumbers>(){Data = new CallNumbers("135", "Dreams and mysteries"), Parent = tree.Root.Children[0].Children[2]}                                                                
            };

            tree.Root.Children[0].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                        
            {                                                                                                                                
                new TreeNode<CallNumbers>(){Data = new CallNumbers("141", "Idealism and related systems and doctrines"), Parent = tree.Root.Children[0].Children[3]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("142", "Critical philosophy"), Parent = tree.Root.Children[0].Children[3]},                        
                new TreeNode<CallNumbers>(){Data = new CallNumbers("143", "Bergsonism and intuitionism"), Parent = tree.Root.Children[0].Children[3]}                 
            };

            tree.Root.Children[0].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                                              
            {                                                                                                                                                      
                new TreeNode<CallNumbers>(){Data = new CallNumbers("152", "Sensory perception, movement, emotions, and physiological drives"), Parent = tree.Root.Children[0].Children[4]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("153", "Conscious mental processes and intelligence"), Parent = tree.Root.Children[0].Children[4]},                      
                new TreeNode<CallNumbers>(){Data = new CallNumbers("154", "Subconscious and altered states and processes"), Parent = tree.Root.Children[0].Children[4]}                   
            };

            tree.Root.Children[1].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                               
            {                                                                                                                                       
                new TreeNode<CallNumbers>(){Data = new CallNumbers("211", "Concepts of God"), Parent = tree.Root.Children[1].Children[0]},                                   
                new TreeNode<CallNumbers>(){Data = new CallNumbers("212", "Existence, ways of knowing God, attributes of God"), Parent = tree.Root.Children[1].Children[0]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("213", "Creation"), Parent = tree.Root.Children[1].Children[0]}                                           
            };

            tree.Root.Children[1].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                        
            {                                                                                                                                
                new TreeNode<CallNumbers>(){Data = new CallNumbers("221", "Old Testament (Tanakh)"), Parent = tree.Root.Children[1].Children[1]},                     
                new TreeNode<CallNumbers>(){Data = new CallNumbers("222", "Historical books of Old Testament"), Parent = tree.Root.Children[1].Children[1]},          
                new TreeNode<CallNumbers>(){Data = new CallNumbers("223", "Poetic books of Old Testament"), Parent = tree.Root.Children[1].Children[1]}               
            };

            tree.Root.Children[1].Children[2].Children = new List<TreeNode<CallNumbers>>()                                         
            {                                                                                                                  
                new TreeNode<CallNumbers>(){Data = new CallNumbers("231", "God"), Parent = tree.Root.Children[1].Children[2]},                          
                new TreeNode<CallNumbers>(){Data = new CallNumbers("232", "Jesus Christ and his family"), Parent = tree.Root.Children[1].Children[2]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("233", "Humankind"), Parent = tree.Root.Children[1].Children[2]}                     
            };

            tree.Root.Children[1].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                              
            {                                                                                                                                     
                new TreeNode<CallNumbers>(){Data = new CallNumbers("241", "Christian ethics"), Parent = tree.Root.Children[1].Children[3]},                                  
                new TreeNode<CallNumbers>(){Data = new CallNumbers("242", "Devotional literature"), Parent = tree.Root.Children[1].Children[3]},                             
                new TreeNode<CallNumbers>(){Data = new CallNumbers("243", "Evangelistic writings for individuals and families"), Parent = tree.Root.Children[1].Children[3]} 
            };

            tree.Root.Children[1].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                        
            {                                                                                                                                 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("251", "Preaching (Homiletics)"), Parent = tree.Root.Children[1].Children[4]},                      
                new TreeNode<CallNumbers>(){Data = new CallNumbers("252", "Texts of sermons"), Parent = tree.Root.Children[1].Children[4]},                            
                new TreeNode<CallNumbers>(){Data = new CallNumbers("253", "Pastoral office and work (Pastoral theology)"), Parent = tree.Root.Children[1].Children[4]} 
            };


            tree.Root.Children[2].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                               
            {                                                                                                                                      
                new TreeNode<CallNumbers>(){Data = new CallNumbers("314", "General statistics of Europe"), Parent = tree.Root.Children[2].Children[0]},                      
                new TreeNode<CallNumbers>(){Data = new CallNumbers("315", "General statistics of Asia"), Parent = tree.Root.Children[2].Children[0]},                      
                new TreeNode<CallNumbers>(){Data = new CallNumbers("316", "General statistics of Africa"), Parent = tree.Root.Children[2].Children[0]}                       
            };

            tree.Root.Children[2].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                                     
            {                                                                                                                                           
                new TreeNode<CallNumbers>(){Data = new CallNumbers("321", "Systems of governments and states"), Parent = tree.Root.Children[2].Children[1]},                     
                new TreeNode<CallNumbers>(){Data = new CallNumbers("322", "Relation of state to organized groups and their members"), Parent = tree.Root.Children[2].Children[1]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("323", "Civil and political rights"), Parent = tree.Root.Children[2].Children[1]}                               
            };

            tree.Root.Children[2].Children[2].Children = new List<TreeNode<CallNumbers>>()                                          
            {                                                                                                                 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("331", "Labour economics"), Parent = tree.Root.Children[2].Children[2]},             
                new TreeNode<CallNumbers>(){Data = new CallNumbers("332", "Financial economics"), Parent = tree.Root.Children[2].Children[2]},          
                new TreeNode<CallNumbers>(){Data = new CallNumbers("333", "Economics of land and energy"), Parent = tree.Root.Children[2].Children[2]}  
            };

            tree.Root.Children[2].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                                                                   
            {                                                                                                                                                                             
                new TreeNode<CallNumbers>(){Data = new CallNumbers("341", "Law of nations"), Parent = tree.Root.Children[2].Children[3]},                                                                           
                new TreeNode<CallNumbers>(){Data = new CallNumbers("342", "Constitutional and administrative law"), Parent = tree.Root.Children[2].Children[3]},                                                    
                new TreeNode<CallNumbers>(){Data = new CallNumbers("343", "Military, defense, public property, public finance, tax, commerce (trade), industrial law"), Parent = tree.Root.Children[2].Children[3]} 
            };

            tree.Root.Children[2].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                               
            {                                                                                                                                      
                new TreeNode<CallNumbers>(){Data = new CallNumbers("351", "Public administration"), Parent = tree.Root.Children[2].Children[4]},                            
                new TreeNode<CallNumbers>(){Data = new CallNumbers("352", "General considerations of public administration"), Parent = tree.Root.Children[2].Children[4]},   
                new TreeNode<CallNumbers>(){Data = new CallNumbers("353", "Specific fields of public administration"), Parent = tree.Root.Children[2].Children[4]}           
            };

        
            tree.Root.Children[3].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                               
            {                                                                                                                                       
                new TreeNode<CallNumbers>(){Data = new CallNumbers("411", "Writing systems of standard forms of languages"), Parent = tree.Root.Children[3].Children[0]},    
                new TreeNode<CallNumbers>(){Data = new CallNumbers("412", "Etymology of standard forms of languages"), Parent = tree.Root.Children[3].Children[0]},         
                new TreeNode<CallNumbers>(){Data = new CallNumbers("413", "Dictionaries of standard forms of languages"), Parent = tree.Root.Children[3].Children[0]}        
            };

            tree.Root.Children[3].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                                      
            {                                                                                                                                              
                new TreeNode<CallNumbers>(){Data = new CallNumbers("421", "Writing system, phonology, phonetics of standard English"), Parent = tree.Root.Children[3].Children[1]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("422", "Etymology of standard English"), Parent = tree.Root.Children[3].Children[1]},                           
                new TreeNode<CallNumbers>(){Data = new CallNumbers("423", "Dictionaries of standard English"), Parent = tree.Root.Children[3].Children[1]}                         
            };

            tree.Root.Children[3].Children[2].Children = new List<TreeNode<CallNumbers>>()                                                                         
            {                                                                                                                                                
                new TreeNode<CallNumbers>(){Data = new CallNumbers("431", "Writing systems, phonology, phonetics of standard German"), Parent = tree.Root.Children[3].Children[2]},   
                new TreeNode<CallNumbers>(){Data = new CallNumbers("432", "Etymology of standard German"), Parent = tree.Root.Children[3].Children[2]},                                
                new TreeNode<CallNumbers>(){Data = new CallNumbers("433", "Dictionaries of standard German"), Parent = tree.Root.Children[3].Children[2]}                             
            };

            tree.Root.Children[3].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                                      
            {                                                                                                                                          
                new TreeNode<CallNumbers>(){Data = new CallNumbers("441", "Writing systems, phonology, phonetics of standard French"), Parent = tree.Root.Children[3].Children[3]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("442", "Etymology of standard French"), Parent = tree.Root.Children[3].Children[3]},                             
                new TreeNode<CallNumbers>(){Data = new CallNumbers("443", "Dictionaries of standard French"), Parent = tree.Root.Children[3].Children[3]}                           
            };

            tree.Root.Children[3].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                                        
            {                                                                                                                                                
                new TreeNode<CallNumbers>(){Data = new CallNumbers("451", "Writing systems, phonology, phonetics of standard Italian"), Parent = tree.Root.Children[3].Children[4]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("452", "Etymology of standard Italian"), Parent = tree.Root.Children[3].Children[4]},                              
                new TreeNode<CallNumbers>(){Data = new CallNumbers("453", "Dictionaries of standard Italian"), Parent = tree.Root.Children[3].Children[4]}                            
            };

       
            tree.Root.Children[4].Children[0].Children = new List<TreeNode<CallNumbers>>()                                                  
            {                                                                                                                         
                new TreeNode<CallNumbers>(){Data =  new CallNumbers("511", "General principles of mathematics"), Parent = tree.Root.Children[4].Children[0]},   
                new TreeNode<CallNumbers>(){Data =  new CallNumbers("512", "Algebra"), Parent = tree.Root.Children[4].Children[0]},                             
                new TreeNode<CallNumbers>(){Data =  new CallNumbers("513", "Arithmetic"), Parent = tree.Root.Children[4].Children[0]}                          
            };

            tree.Root.Children[4].Children[1].Children = new List<TreeNode<CallNumbers>>()                                                                      
            {                                                                                                                                              
                new TreeNode<CallNumbers>(){Data = new CallNumbers("521", "Celestial mechanics"), Parent = tree.Root.Children[4].Children[1]}, 
                new TreeNode<CallNumbers>(){Data = new CallNumbers("522", "Techniques, procedures, apparatus, equipment, materials"), Parent = tree.Root.Children[4].Children[1]},                           
                new TreeNode<CallNumbers>(){Data = new CallNumbers("523", "Specific celestial bodies and phenomena"), Parent = tree.Root.Children[4].Children[1]}                          
            };

            tree.Root.Children[4].Children[2].Children = new List<TreeNode<CallNumbers>>()                                       
            {                                                                                                               
                new TreeNode<CallNumbers>(){Data = new CallNumbers("531", "Classical mechanics"), Parent = tree.Root.Children[4].Children[2]},       
                new TreeNode<CallNumbers>(){Data = new CallNumbers("532", "Fluid mechanics"), Parent = tree.Root.Children[4].Children[2]},          
                new TreeNode<CallNumbers>(){Data = new CallNumbers("533", "Pneumatics (Gas mechanics)"), Parent = tree.Root.Children[4].Children[2]} 
            };

            tree.Root.Children[4].Children[3].Children = new List<TreeNode<CallNumbers>>()                                                                      
            {                                                                                                                                              
                new TreeNode<CallNumbers>(){Data = new CallNumbers("541", "Physical chemistry"), Parent = tree.Root.Children[4].Children[3]},                                       
                new TreeNode<CallNumbers>(){Data = new CallNumbers("542", "Techniques, procedures, apparatus, equipment, materials"), Parent = tree.Root.Children[4].Children[3]},  
                new TreeNode<CallNumbers>(){Data = new CallNumbers("543", "Analytical chemistry"), Parent = tree.Root.Children[4].Children[3]}                                      
            };

            tree.Root.Children[4].Children[4].Children = new List<TreeNode<CallNumbers>>()                                                                        
            {                                                                                                                                               
                new TreeNode<CallNumbers>(){Data = new CallNumbers("551", "Geology, hydrology, meteorology"), Parent = tree.Root.Children[4].Children[4]},  
                new TreeNode<CallNumbers>(){Data = new CallNumbers("552", "Petrology"), Parent = tree.Root.Children[4].Children[4]},                             
                new TreeNode<CallNumbers>(){Data = new CallNumbers("553", "Economic geology"), Parent = tree.Root.Children[4].Children[4]}                            
            };

        }


    }
}

//Kini, M. 2020. Tree data structure. [Online]. [Accessed: 20 November 2023].
//reference: https://www.c-sharpcorner.com/article/tree-data-structure/