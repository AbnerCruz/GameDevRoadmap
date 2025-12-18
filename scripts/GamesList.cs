namespace RoadMap;

public class GamesList
{
    public static List<Game> Games = new()
    {
        // --- Arcade Clássicos ---
        new()
        {
            Name = "Pong",
            Repository = "",
            Genres = new() { "Arcade", "Esporte" },
            Objectives = new() { "Rebater a bola para o lado do oponente", "Evitar que a bola passe pela sua paleta", "Marcar pontuação máxima" }
        },
        new()
        {
            Name = "Breakout",
            Repository = "",
            Genres = new() { "Arcade", "Quebra-tijolos" },
            Objectives = new() { "Destruir todos os tijolos da tela", "Manter a bola em jogo", "Coletar power-ups (se houver)" }
        },
        new()
        {
            Name = "Snake",
            Repository = "",
            Genres = new() { "Arcade", "Puzzle" },
            Objectives = new() { "Comer a comida para crescer", "Evitar colidir com as paredes", "Evitar colidir com o próprio corpo" }
        },
        new()
        {
            Name = "Flappy Bird",
            Repository = "",
            Genres = new() { "Arcade", "Endless Runner" },
            Objectives = new() { "Manter o personagem no ar com toques", "Passar pelos vãos dos canos", "Obter a maior pontuação possível" }
        },
        new()
        {
            Name = "Space Invaders",
            Repository = "",
            Genres = new() { "Arcade", "Shooter", "Fixed Shooter" },
            Objectives = new() { "Destruir as ondas de alienígenas", "Desviar dos projéteis inimigos", "Proteger as barreiras defensivas" }
        },
        new()
        {
            Name = "Tetris",
            Genres = new() { "Puzzle", "Estratégia" },
            Objectives = new() { "Encaixar as peças (tetrominós)", "Completar linhas horizontais para pontuar", "Impedir que a pilha chegue ao topo" }
        },
        new()
        {
            Name = "Frogger",
            Genres = new() { "Arcade" },
            Objectives = new() { "Atravessar a estrada sem ser atropelado", "Atravessar o rio pulando em troncos", "Chegar à toca em segurança" }
        },
        new()
        {
            Name = "Asteroids",
            Genres = new() { "Arcade", "Shooter", "Multidirectional Shooter" },
            Objectives = new() { "Destruir asteroides e discos voadores", "Gerenciar o momento (inércia) da nave", "Evitar colisões com detritos" }
        },
        new()
        {
            Name = "Pac-Man",
            Genres = new() { "Arcade", "Labirinto" },
            Objectives = new() { "Comer todas as pastilhas do labirinto", "Fugir dos fantasmas", "Usar pastilhas de força para comer fantasmas" }
        },
        new()
        {
            Name = "Galaga",
            Genres = new() { "Arcade", "Fixed Shooter" },
            Objectives = new() { "Eliminar inimigos em formação", "Resgatar nave capturada para poder duplo", "Desviar de mergulhos kamikaze" }
        },
        new()
        {
            Name = "Donkey Kong",
            Genres = new() { "Arcade", "Plataforma" },
            Objectives = new() { "Subir as plataformas e escadas", "Desviar de barris", "Resgatar a personagem no topo" }
        },
        new()
        {
            Name = "Q*bert",
            Genres = new() { "Arcade", "Puzzle", "Isométrico" },
            Objectives = new() { "Pular em todos os cubos para mudar a cor", "Evitar inimigos e cair do cenário", "Usar discos de transporte" }
        },
        new()
        {
            Name = "Dig Dug",
            Genres = new() { "Arcade", "Labirinto" },
            Objectives = new() { "Escavar túneis no subsolo", "Eliminar monstros inflando-os ou usando pedras", "Coletar vegetais bônus" }
        },
        new()
        {
            Name = "Centipede",
            Genres = new() { "Arcade", "Shooter" },
            Objectives = new() { "Atirar nos segmentos da centopeia", "Desviar de aranhas e escorpiões", "Gerenciar a área de cogumelos" }
        },
        new()
        {
            Name = "Defender",
            Genres = new() { "Arcade", "Side Scroller", "Shooter" },
            Objectives = new() { "Destruir ondas alienígenas", "Proteger astronautas de abdução", "Gerenciar o radar e o cenário cíclico" }
        },
        new()
        {
            Name = "Scramble",
            Genres = new() { "Arcade", "Side Scroller", "Shooter" },
            Objectives = new() { "Navegar por cavernas estreitas", "Bombardeitar alvos no solo", "Gerenciar o combustível da nave" }
        },
        new()
        {
            Name = "Tempest",
            Genres = new() { "Arcade", "Tube Shooter" },
            Objectives = new() { "Eliminar inimigos que sobem pelo tubo", "Evitar ser pego na borda", "Usar o Superzapper em emergências" }
        },
        new()
        {
            Name = "Robotron: 2084",
            Genres = new() { "Arcade", "Twin-Stick Shooter" },
            Objectives = new() { "Destruir todos os robôs na tela", "Salvar os últimos humanos", "Sobreviver ao caos" }
        },
        new()
        {
            Name = "Joust",
            Genres = new() { "Arcade", "Plataforma" },
            Objectives = new() { "Voar e colidir com inimigos estando mais alto", "Coletar ovos antes que choquem", "Sobreviver às ondas de cavaleiros" }
        },
        new()
        {
            Name = "Marble Madness",
            Genres = new() { "Arcade", "Puzzle", "Isométrico" },
            Objectives = new() { "Guiar a bola até o final do percurso", "Evitar cair das bordas", "Gerenciar o tempo limite" }
        },

        // --- Arcade Expandidos ---
        new()
        {
            Name = "Expanded Pong",
            Genres = new() { "Arcade", "Moderno" },
            Objectives = new() { "Implementar power-ups (velocidade, tamanho)", "Adicionar obstáculos no campo", "Criar modos multiplayer locais" }
        },
        new()
        {
            Name = "Expanded Space Invaders",
            Genres = new() { "Shooter", "Moderno" },
            Objectives = new() { "Adicionar padrões de ataque complexos (Bosses)", "Implementar sistema de upgrade de armas", "Criar progressão de fases" }
        },

        // --- Clicker / Idle ---
        new()
        {
            Name = "Cookie Clicker",
            Genres = new() { "Idle", "Clicker", "Simulação" },
            Objectives = new() { "Gerar recursos clicando manualmente", "Comprar estruturas para geração automática", "Desbloquear upgrades e conquistas" }
        },
        new()
        {
            Name = "AdVenture Capitalist",
            Genres = new() { "Idle", "Simulação Econômica" },
            Objectives = new() { "Gerenciar múltiplos negócios", "Otimizar lucros e velocidade de produção", "Reiniciar o jogo com multiplicadores (Prestígio)" }
        },

        // --- 2D Static Puzzle ---
        new()
        {
            Name = "Minesweeper",
            Genres = new() { "Puzzle", "Lógica" },
            Objectives = new() { "Revelar todas as células sem minas", "Marcar locais suspeitos com bandeiras", "Usar lógica numérica para dedução" }
        },
        new()
        {
            Name = "Sokoban (Opcional)",
            Genres = new() { "Puzzle", "Lógica" },
            Objectives = new() { "Empurrar caixas para os locais marcados", "Planejar movimentos para não prender caixas", "Resolver o nível com o menor número de passos" }
        },

        // --- Visual Novel / Narrative ---
        new()
        {
            Name = "Phoenix Wright Inspired",
            Genres = new() { "Visual Novel", "Detetive" },
            Objectives = new() { "Investigar cenas de crime", "Encontrar contradições em depoimentos", "Apresentar evidências no tribunal" }
        },
        new()
        {
            Name = "Doki Doki Literature Club Inspired",
            Genres = new() { "Visual Novel", "Terror Psicológico" },
            Objectives = new() { "Interagir com personagens através de diálogos", "Escrever poemas escolhendo palavras-chave", "Descobrir os segredos por trás da narrativa" }
        },

        // --- Basic 2D Tower Defense ---
        new()
        {
            Name = "Plants vs. Zombies Inspired",
            Genres = new() { "Tower Defense", "Estratégia" },
            Objectives = new() { "Coletar recursos (sol)", "Posicionar unidades defensivas em linhas", "Impedir que inimigos cruzem o jardim" }
        },
        new()
        {
            Name = "Bloons TD Inspired",
            Genres = new() { "Tower Defense" },
            Objectives = new() { "Posicionar torres ao longo do caminho", "Melhorar torres para lidar com tipos específicos de inimigos", "Sobreviver a todas as ondas" }
        },

        // --- Simple 2D Platformer ---
        new()
        {
            Name = "Super Mario Bros Inspired",
            Genres = new() { "Plataforma", "Aventura" },
            Objectives = new() { "Chegar ao final da fase dentro do tempo", "Coletar moedas e power-ups", "Derrotar inimigos pulando sobre eles" }
        },
        new()
        {
            Name = "Classic Mega Man Inspired",
            Genres = new() { "Plataforma", "Ação" },
            Objectives = new() { "Atirar em inimigos à distância", "Derrotar chefes para ganhar novas armas", "Superar desafios de plataforma precisos" }
        },

        // --- Top-Down Shooter ---
        new()
        {
            Name = "Hotline Miami Inspired",
            Genres = new() { "Top-Down Shooter", "Ação Tática" },
            Objectives = new() { "Eliminar todos os inimigos da fase", "Morrer e reiniciar instantaneamente (Trial and Error)", "Usar armas brancas e de fogo estrategicamente" }
        },
        new()
        {
            Name = "Geometry Wars Inspired",
            Genres = new() { "Twin-Stick Shooter", "Arcade" },
            Objectives = new() { "Sobreviver em uma arena fechada", "Destruir formas geométricas inimigas", "Coletar multiplicadores de pontuação" }
        },

        // --- 2D Beat'em Up ---
        new()
        {
            Name = "Streets of Rage 2 Inspired",
            Genres = new() { "Beat'em Up", "Ação" },
            Objectives = new() { "Caminhar para a direita derrotando capangas", "Usar combos e ataques especiais", "Derrotar o chefe da fase" }
        },

        // --- 2D Turn-Based RPG ---
        new()
        {
            Name = "Pokémon Red/Blue Inspired",
            Genres = new() { "RPG", "Turn-Based", "Colecionável" },
            Objectives = new() { "Capturar e treinar criaturas", "Batalhar em turnos escolhendo ataques", "Explorar o mundo e derrotar líderes de ginásio" }
        },
        new()
        {
            Name = "Final Fantasy (NES) Inspired",
            Genres = new() { "RPG", "Turn-Based" },
            Objectives = new() { "Gerenciar um grupo de heróis (Party)", "Explorar calabouços e mapa múndi", "Gerenciar inventário e magias" }
        },

        // --- 2D Metroidvania ---
        new()
        {
            Name = "Metroid Inspired",
            Genres = new() { "Metroidvania", "Ação", "Plataforma" },
            Objectives = new() { "Explorar um mapa não linear", "Encontrar upgrades para acessar novas áreas", "Backtracking para descobrir segredos" }
        },
        new()
        {
            Name = "Castlevania: SotN Inspired",
            Genres = new() { "Metroidvania", "RPG de Ação" },
            Objectives = new() { "Combater inimigos com armas variadas", "Ganhar experiência e subir de nível", "Explorar o castelo labiríntico" }
        },

        // --- 2D Roguelike ---
        new()
        {
            Name = "The Binding of Isaac Inspired",
            Genres = new() { "Roguelike", "Dungeon Crawler" },
            Objectives = new() { "Explorar salas geradas proceduralmente", "Coletar itens que modificam os tiros", "Derrotar o chefe do andar para descer" }
        },
        new()
        {
            Name = "Spelunky Inspired",
            Genres = new() { "Roguelike", "Plataforma" },
            Objectives = new() { "Descer o máximo possível na caverna", "Gerenciar recursos (bombas, cordas)", "Lidar com armadilhas mortais e física" }
        },

        // --- 2D Farming/Survival ---
        new()
        {
            Name = "Stardew Valley Inspired",
            Genres = new() { "Simulação", "Farming", "RPG" },
            Objectives = new() { "Limpar e organizar a fazenda", "Plantar colheitas e regar diariamente", "Interagir com NPCs da cidade" }
        },
        new()
        {
            Name = "Don't Starve Inspired (2D Demake)",
            Genres = new() { "Survival", "Crafting" },
            Objectives = new() { "Coletar recursos para não morrer de fome", "Manter a sanidade mental", "Construir base e fogueira para a noite" }
        },

        // --- 2D City-Builder / Tycoon ---
        new()
        {
            Name = "SimCity Inspired (2D Demake)",
            Genres = new() { "City Builder", "Simulação" },
            Objectives = new() { "Zonear áreas (Residencial, Comercial, Industrial)", "Fornecer energia e água", "Manter o orçamento e a felicidade da população" }
        },
        new()
        {
            Name = "RollerCoaster Tycoon Inspired (2D Demake)",
            Genres = new() { "Tycoon", "Gestão" },
            Objectives = new() { "Construir brinquedos e lojas", "Desenhar o traçado de montanhas-russas", "Gerenciar funcionários e limpeza do parque" }
        },

        // --- Game Jam Ideas (Conceitos Abstratos) ---
        new()
        {
            Name = "Single Pulse",
            Genres = new() { "Experimental", "Rítmico" },
            Objectives = new() { "Realizar a ação apenas no pulso correto", "Sincronizar com a batida cardíaca do jogo", "Minimalismo extremo de input" }
        },
        new()
        {
            Name = "Sliding Synapses",
            Genres = new() { "Puzzle", "Lógica" },
            Objectives = new() { "Conectar nós neurais deslizando peças", "Formar o caminho antes que o sinal expire", "Gerenciar múltiplas conexões simultâneas" }
        },
        new()
        {
            Name = "RhythmoGraph",
            Genres = new() { "Rítmico", "Visualizer" },
            Objectives = new() { "Gerar música através do movimento", "Criar padrões visuais baseados no áudio", "Manter o fluxo contínuo" }
        },
        new()
        {
            Name = "Micro-Platforms",
            Genres = new() { "Plataforma de Precisão" },
            Objectives = new() { "Pular em plataformas minúsculas", "Controlar a inércia com perfeição", "Evitar o vazio" }
        },
        new()
        {
            Name = "Orbital Duet",
            Genres = new() { "Arcade", "Co-op" },
            Objectives = new() { "Controlar dois objetos em órbita mútua", "Evitar obstáculos rotacionando o centro", "Manter a gravidade estável" }
        },
        new()
        {
            Name = "Word Echo",
            Genres = new() { "Puzzle", "Palavras" },
            Objectives = new() { "Reutilizar partes de palavras anteriores", "Formar novas frases com ecos do passado", "Resolver enigmas linguísticos" }
        },
        new()
        {
            Name = "Living Maze",
            Genres = new() { "Labirinto", "Procedural" },
            Objectives = new() { "Navegar em um labirinto que muda sozinho", "Memorizar padrões de alteração", "Encontrar a saída antes que ela suma" }
        },
        new()
        {
            Name = "Reversed Time",
            Genres = new() { "Puzzle", "Temporal" },
            Objectives = new() { "Executar ações pensando no rebobinamento", "Usar o 'eu' do futuro para ajudar o 'eu' do passado", "Corrigir paradoxos" }
        },
        new()
        {
            Name = "Shared Body",
            Genres = new() { "Co-op", "Física" },
            Objectives = new() { "Dois jogadores controlam membros diferentes", "Coordenar movimentos para andar", "Realizar tarefas simples com dificuldade elevada" }
        },
        new()
        {
            Name = "Pixel Rebellion",
            Genres = new() { "Ação", "Meta-Game" },
            Objectives = new() { "Lutar contra a própria interface do jogo", "Destruir a barra de vida do inimigo literalmente", "Quebrar as regras do código" }
        }
    };
}

public class Game
{
    public string Name = string.Empty;
    public string Repository = string.Empty;
    public List<string> Genres = new();
    public List<string> Objectives = new();
}