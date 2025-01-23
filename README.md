# InjecaoDeDependencia
📌 Você sabe como a Injeção de dependência funciona na prática? Caso a respostar for não, este projeto te ajudará!
Vamos supor que você esteja desenvolvendo um aplicativo que precisa se conectar a um banco de dados. 
Ao invés de criar uma classe que faça a conexão diretamente, você cria uma interface que define os métodos que essa classe deve ter, como "Cadastrar", "Deletar" e "Editar".
Você implementa essa interface em uma classe concreta, por exemplo um repository que irá e realiza a conexão com um banco de dados específico.
Agora, ao invés de outras classes do seu sistema dependerem diretamente da classe de conexão com o banco, elas dependem da interface genérica que você definiu.
E é aí que a injeção de dependência entra em ação. Em vez de instanciar diretamente a classe de conexão dentro das classes dependentes, você assegura que essa dependência seja "injetada" por meio de construtores, métodos ou até mesmo configurações externas.
OBS: Eu estou utilizando a classe Controller para receber e tratar os dados e depois enviar para a classe Repository que fara as consultas.
