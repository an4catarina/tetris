### Olá!

Neste repositório contém o meu trabalho final de Algorítimo e Programação, onde eu criei um Tetris clone em C# feito com o auxílio do Unity.  
A decisão de fazer um Tetris em C# veio após eu assistir um vídeo na semana universitária da UnB no qual mostrava um pouco sobre a criação de jogos pelo Unity, onde eu obtive interesse pela plataforma e a partir daí eu tive a ideia de fazer o meu projeto por lá!  
O tempo de criação do jogo durou mais ou menos 1 mês, fiz ele com o auxílio de aulas básicas no youtube sobre C# - na qual até então era uma lingaugem desconhecida para mim - e sobre o funcionamento do Tetris. O jogo em si está simples, ele cumpre o objetivo de jogar as peças e sumir com linhas inteiras e meus planos para o futuro é adicionar os sistemas de mostrar a próxima peça, o de game over e o de pontuação, aos quais eu não consegui implementar por causa de alguns bugs que apareciam no processo de construção dos mesmos.  
Resumindo, a construção desse jogo levou algumas etapas:  
1- Pesquisa e estudos sobre C# e a criação de Tetris com o Unity;   
2- Definição dos 7 Tetraminós (as peças do jogo) e da grade de fundo como Prefabs;  
3- Criação de dois scripts, um chamado Tetraminós e o segundo chamado de Grid;  
4- O foco principal foi no Script dos Tetraminós, comecei fazendo com que as peças se movam e respeitam o limite da grade;  
5- Depois de estabelecer o limite eu criei mais um script que define onde as peças vão fazer o Spawn;  
6- Criação do sistema de colisão das peças;  
7- Criação do sistema de apagar linhas cheias;  
A parte mais desafiadora na produção desse jogo definitivamente foi a criação do sistema que apaga linhas cheias, no qual foi um código extenso que tiveram vários bugs a serem resolvidos no processo de montagem do mesmo!  
    
      
## É importante lembrar que:  
1- O jogo não está completo, funcionalidades como o de game over ou o de recomeçar o jogo infelizmente ainda não foram implementadas, por isso, quando quiser recomeçar o jogo ele deve ser fechado e aberto novamente;    
2- Ainda existem alguns bugs aos quais eu não consegui resolver, são eles:  
- Quando jogamos a peça até o último espaço da direita, a mesma pode sair da grade, bloqueando o jogo;  
- Quando as peças chegam no topo a funcionalidade de Spawnar as peças para de funcionar;   
  Para resolver ambos problemas, é necessário fechar e abrir o jogo novamente! :)   
    
      
Para abrir o jogo basta baixar a pasta Tetris_Mac_Windows.zip e descompactá-la. Se você estiver em um windows, basta rodar o arquive .exe em sua respectiva pasta, se você estiver em um macOS basta abrir o único arquivo disponível! 
  
Lembrando que eu estou aprendendo, qualquer feedback, ajuda ou opinião são bem vindos! :V   
Aqui está um pouquinho do jogo:

![ezgif com-gif-maker](https://user-images.githubusercontent.com/89619442/140665569-de7ab654-8441-45a0-93cd-862c04e4131f.gif)
