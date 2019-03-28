# Gerador Gramatica Aleatoria

Trabalho de linguagens formais

Algoritmo a ser implementado:
a) Escolha de forma arbitrária uma das produções do lado direito.
b) Coloque em uma pilha a produção escolhida, onde o símbolo mais a esquerda da produção deve estar no topo da pilha.
c) Enquanto a pilha não estiver vazia faça:
-Retire o elemento do topo da pilha
-Se o elemento for um terminal, adicione o elemento a saída
-Se o elemento for um não terminal, procure pelo não terminal do lado esquerdo da gramática e repita os passos a partir de “a”.
