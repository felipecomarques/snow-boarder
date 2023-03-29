<h1 align = "center">
  Snow Boarder
</h1>

## 📄 About
<p> <strong>(NÃO FINALIZADO!)</strong> Segundo projeto do <a href="https://www.udemy.com/course/unitycourse/">curso de desenvolvedor de jogos 2D em Unity e C#</a>. Esse projeto tem como objetivo ensinar sprite shapes, edge colliders, dentre outros. Deste modo, foi realizado um jogo simples, que consiste em um persoangem que surfa na neve e chega no objetivo. </p> 

## 🛣️ Imagem
Sem imagem ainda...

## 🖥️ Scripts
Em resumo, o que foi ensinado em relação à código pode ser resumido nesses três scripts:
+ <a href="https://github.com/felipecomarques/snow-boarder/blob/main/Assets/Scripts/PlayerController.cs">PlayerController.cs</a> - responsável pelo controle do personagem.
+ <a href="https://github.com/felipecomarques/snow-boarder/blob/main/Assets/Scripts/CrashDetector.cs">CrashDetector.cs</a> - responsável pela lógica de colidir com o chão.
+ <a href="https://github.com/felipecomarques/snow-boarder/blob/main/Assets/Scripts/FinishLine.cs">FinishLine.cs</a> - responsável pela detecção de colidir com o objetivo final

## 📖 Aprendizados detalhados deste módulo
Os ensinamentos detalhados desse módulo são:
+ Sprite shape: inicia-se criando um sprite shape para formação do layout no jogo. É criado um profile dentro da pasta assets, que será aplicado ao objeto. É adicionado um sprite e uma textura a esse profile. Assim, iremos clicar em `Edit Spline` para criar e editar o layout inicial.
+ Adicionado Edge Collider: para que exista colisão no layout, é adicionado um `Edge Collider 2D`. Essa colisão será atualizada automaticamente com junto com o layout do nível.
+ Adicionado um dynamic sprite: um círculo que já possuirá um Collider2D e um RigidBody2D. Depois, é necessário alterar o offset na colisão do Level Sprite Shape, senão o círculo ficará flutuando.
+ Cinemachine: instalado o pacote cinemachine pelo package manager. Adicionado uma câmera virtual, que será adicionado automáticamente como componente da câmera principal. É alterado o body para a seleção `Framing Transposer`. Depois, é adicionado o sprite do círculo para a seleção `Follow`, onde a câmera começará a segui-lá. Para conseguirmos ver mais adiante no nível, mudamos o valor da variável `Screen X` dentro de body.
+ Adicionar o personagem: removido spriteRenderer e collider2D. Adicionamos os dois spirtes dentro da objeto. É ajustado a posição de ambas as partes, para que assim fiquem juntas e também centradas baseadas do objeto pai. É alterado a layer dos objetos filhos para que não caiam atrás do layout. É mais endireitado o possível para que sejam adicionados duas colisões no objeto pai: uma cápsula horizontal para a prancha e um círculo IsTrigger para a cabeça.
+ Adicionar torque: É criado um script que será adicionado ao personagem. Nele será criado uma variável do tipo `Rigidbody2D`, que no método start() receberá um getComponent para o RigidBody2D do objeto. No método upadate será criado uma condição para verificar o Input do teclado (esquerda ou direita), e dentro dela haverá essa mesma variável que será adicionado o torque com `AddTorque(valor)`. É necessário alterar o `LinerDrag` e `AngularDrag` para o personagem não girar tanto.
+ Objetivo e fim de jogo: adicionado dois scipts, um para verificar colisão e outro pra checar se atingiu o objetivo. Criado um poste que será o objetivo final, e adicionado uma colisão 'isTrigger'. Adicionado um script com a função `OnTriggerEnter2D` quando algo com a tag "Player" passar pelo poste. O outro script será colocado no personagem com a mesma função quando algo com a tag "Ground" colidir.
+ Função de reiniciar no jogo: Adicionado namespace `UnityEngine.SceneManagement`. Assim, será adicionado `SceneManager.LoadScene(IndexDaCena)` para ambos os scripts para reiniciar no nível.
+ Adicionar delay: Para adicionar um delay antes do nível reiniciar, usamos `Involke("MétodoAqui", SegundosAqui)`. Deste modo, é criado um método separado para reiniciar o nível.