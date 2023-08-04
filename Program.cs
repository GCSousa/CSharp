
//List<String> listaTarefas = new List<string>();
List<String> listaTarefas = new List<string> { "estudar", "limpar a casa", "estudar programação" };

ExibirOpcoesMenu();

void MostraTarefas()
{
  Console.WriteLine("*****************");
  Console.WriteLine("Lista de tarefas");
  Console.WriteLine("******************");

  // for (int i = 0; i < listaTarefas.Count; i++){
  //   Console.WriteLine(listaTarefas[i]); 
  // }

  foreach (string tarefa in listaTarefas)
  {
    Console.WriteLine($"tarefa: {tarefa}");
  }

  Console.ReadKey();
  Console.Clear();
  ExibirOpcoesMenu();
}

void RegistraTarefa()
{
  Console.Write("\n");
  Console.WriteLine("********************");
  Console.WriteLine("Registro de tarefas");
  Console.WriteLine("********************");

  Console.WriteLine("\nDiga o nome da tarefa:");
  String tarefa = Console.ReadLine()!;
  listaTarefas.Add(tarefa);

  Console.WriteLine($"A tarefa {tarefa} foi registrada com sucesso!");
  Console.Clear();
  Thread.Sleep(1000);
  ExibirOpcoesMenu();
}

void ExibirMensagem()
{
  Console.Write("\n");
  Console.WriteLine(" ███████╗░█████╗░██╗░░░░░██╗░░██╗░█████╗░  ██████╗░░█████╗░███╗░░██╗████████╗░█████╗░");
  Console.WriteLine(" ██╔════╝██╔══██╗██║░░░░░██║░░██║██╔══██╗  ██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗");
  Console.WriteLine(" █████╗░░██║░░██║██║░░░░░███████║███████║  ██████╔╝██║░░██║██╔██╗██║░░░██║░░░██║░░██║");
  Console.WriteLine(" ██╔══╝░░██║░░██║██║░░░░░██╔══██║██╔══██║  ██╔═══╝░██║░░██║██║╚████║░░░██║░░░██║░░██║");
  Console.WriteLine(" ██║░░░░░╚█████╔╝███████╗██║░░██║██║░░██║  ██║░░░░░╚█████╔╝██║░╚███║░░░██║░░░╚█████╔╝");
  Console.WriteLine(" ╚═╝░░░░░░╚════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚═╝░░░░░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");
  Console.Write("\n");

}
void ExibirOpcoesMenu()
{
  ExibirMensagem();
  Console.WriteLine(" 1- Para registrar uma tarefa");
  Console.WriteLine(" 2- Para listar todos as tarefas");
  Console.WriteLine(" 3- Para registrar os produtos feitos");
  Console.WriteLine(" 4- Para exibir todos as medias\n");

  // Console.WriteLine("Opção " + opcaoescolhida + " selecionada");
  // Console.WriteLine($"Opção {opcaoescolhida} selecionada");
  // Console.WriteLine("Opção {0} selecionada", opcaoescolhida);

  Console.Write("Digite a opção desejada: ");
  string opcaoescolhida = Console.ReadLine()!;
  int opcaoescolhidanum = int.Parse(opcaoescolhida);
  Console.Clear();

  switch (opcaoescolhidanum)
  {
    case 1:
      RegistraTarefa();
      break;
    case 2:
      MostraTarefas();
      break;
    case 3:
      Console.WriteLine("Opção {0} selecionada", opcaoescolhida);
      break;
    case 4:
      Console.WriteLine("Opção " + opcaoescolhida + " selecionada");
      break;
    default:
      Console.WriteLine("Opção invalida");
      break;

  }
}

