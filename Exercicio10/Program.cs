    using System;

    class Program{
        static void Main(string[] args){
            List<string> tasksList = new List<string>();

            List<string> tasksCompleted = new List<string>();

            

            int i = 1;


            // i = 0 COMANDO INVALIDO
            // i = 1 INICIO
            // i = 2 ADD TAREFA
            // i = 3 COMPLETAR TAREFA
            // i = 4 LISTAR TAREFAS

            bool painel = true;

            while(painel){

                showMenu();

                int.TryParse(Console.ReadLine(), out i);

                if( i == 1){
                    Console.Clear();
                    Console.WriteLine("Digite sua Tarefa: ");
                    tasksList.Add(Console.ReadLine());
                }else if(i == 2){
                    Console.Clear();

                    if(tasksList.Count > 0){
                        
                        listTasks(tasksList);
                        Console.WriteLine("\nSelecione o numero da Tarefa a Concluir: ");
                        int.TryParse(Console.ReadLine(), out int indexTask);
                        if (indexTask == 0 || indexTask > tasksList.Count){
                             Console.WriteLine("Tarefa invalida.");
                             endFunction();
                        }else{
                            indexTask --;
                            
                            tasksCompleted.Add(tasksList[indexTask]);
                            tasksList.Remove(tasksList[indexTask]);
                        }
                    }else{
                         Console.WriteLine("Nenhuma tarefa para completar!");
                         endFunction();
                    }



                }else if(i == 3){
                    listTasks(tasksList);
                    listCompletedTasks(tasksCompleted);
                }else if( i == 4){
                    painel = false;
                    Console.Clear();
                    Console.WriteLine("Fechando programa...\n");
                    Console.ReadLine();
                }else{
                    Console.Clear();
                    Console.WriteLine("Opcao invalida (digite um valor de 1 a 4)\n");
                    Console.ReadLine();
                }

            }



        }

        public static void showMenu(){
            Console.Clear();
            Console.WriteLine("*** Tabela de Tarefas ***\n");
            Console.WriteLine("Opcoes:\n");
            Console.WriteLine("(1) Adicionar Tarefa.\n");
            Console.WriteLine("(2) Completar Tarefa.\n");
            Console.WriteLine("(3) Listar tarefas.\n");
            Console.WriteLine("(4) Sair.\n");
        }

        public static void listTasks(List<String> tasksList){
            Console.Clear();

            if(tasksList.Count > 0){
                Console.WriteLine("Tarefas Pendentes:\n");
                int i = 1;
                foreach(string x in tasksList){
                    Console.WriteLine($"[{i}] {x}");
                    i++;
                }
            }else{
                 Console.WriteLine("Nenhuma tarefa pendente.\n");
            }
            
            
            
        }

        public static void listCompletedTasks(List<String> tasksCompleted){

            if(tasksCompleted.Count > 0){
                Console.WriteLine("\nTarefas Concluidas:\n");
                int i = 1;
                foreach(string x in tasksCompleted){
                    Console.WriteLine($"[{i}] {x}");
                    i++;
                }
            }else{
                 Console.WriteLine("\nNenhuma tarefa Completa.\n");
            }
           
            endFunction();
            
        }

        public static void endFunction(){
            Console.WriteLine("\nPrecione ENTER para continuar...\n");
            Console.ReadLine();
        }

    }