/*---------------------------------------------------------------------*\
|                 ____                     _                            |
|                /    |                   | |_                          |
|               /     |_ __ ____  __ _  __| |_  __ _                    |
|              /  /|  | '__/  __|/ _` |/ _  | |/ _` |                   |
|             /  __   | | |  |__  (_| | (_| | | (_| |                   |
|            /  /  |  |_|  \____|\__,_|\__,_|_|\__,_|                   |
|           /__/   |__|  [ Ragnarok Emulator ]                          |
|                                                                       |
+-----------------------------------------------------------------------+
| - Arquivo de configura��o de Habilidades.                             |
\*---------------------------------------------------------------------*/

skill_config: {

	// A taxa de tempo para conjurar uma magia.
	casting_rate: 100

	// Tempo de delay ap�s conjura��es.
	delay_rate: 100

	// O tempo de delay depende da DES e/ou AGI de quem conjura?
	// Nota: Em servidores oficiais, nem DES nem AGI afetam o tempo de
	delay_dependon_dex: false
	delay_dependon_agi: false

	// Delay m�nimo permitido para QUALQUER habilidade antes de 
	//conjur�-la em milisegundos.
	// Nota: Configurando isto para qualquer valor acima de 0 pode acabar
	//com os speedhacks.
	min_skill_delay_limit: 100

	// Este � o delay m�nimo onde o jogador n�o pode se movimentar para
	//todas as habilidaes.
	// NOTA: N�o defina baixo demais, se um personagem come�ar a se mover
	//logo depois de usar uma habilidade, o client n�o ir� identificar
	//isso, e o jogador/monstro ir� aparecer ap�s "teleportar".
	default_walk_delay: 300

	// Desabilitar completamente o delay das habilidades dos
	//seguintes tipos:
	// NOTA: Por padr�o monstros n�o tem delay nas habilidades, como
	//especificado no banco de dados das habilidades, por�m seguem seu
	//pr�prio delay de 'reuso' que � especificado na mob_skill_db.
	// Quando definido, o delay para todas as habilidades se torna
	//min_skill_delay_limit.
	no_skill_delay: 2

	// Com quantos pontos de DES o tempo de conjura��o se torna zero?
	castrate_dex_scale: 150

	// Quanto (DES*2+INT) vai tonar a conjura��o vari�vel zero?
	vcast_stat_scale: 530

	// Qual grau de suavidade o sistema de habilidades dar� para
	//habilidades quando estiver contabilizando a velocidade de 
	//ataque (ASPD) para habilidades conjur�veis.
	// NOTA: Configurando para 100 pode causar problemas com habilidades
	//v�lidas n�o sendo conjuradas.
	// A diferen�a entre o tempo do client e do servidor varia ent�o
	//habilitando 90% de suavidade deve ser suficiente para compensar
	//pequenas margens de erro.
	// IMPORTANTE: Esta fun��o habilita um pequeno delay, pr�ximo a 2
	//segundos, se ativa.
	// Para desativar, acesse mmo.h e comente a linha #DEFINE NODELAY
	skill_amotion_leniency: 90

	// Ataques normais est�o ignorar�o o delay ap�s o uso de habilidades?
	skill_delay_attack_enable: true

	// Alcance adicionado as habilidades ap�s o tempo de conjura��o
	//terminar.
	// Escolha o quanto longe o alvo pode andar ap�s a habilidade come�ar
	//a ser conjurada antes da habilidade falhar.
	// 0 desabilita esta checagem no alcance (padr�o)
	skill_add_range: 0

	// Se o alvo sair do campo de alcance enquanto a habilidade �
	//conjurada, itens e SP requeridos ser�o consumidos para tal
	//habilidade?
	skill_out_range_consume: false

	// A dist�ncia entre quem conjura e o alvo define se a habilidade �
	//uma habilidade de alcance?
	// Se definida, quando a dist�ncia entre quem conjura e o alvo for
	//maior que 3 a habilidade � de longo-alcance, caso contr�rio o
	//alcance � f�sico.
	// Caso n�o definida, o alcance � determinado pelo alcance de
	//habilidade, se for maior que 5, a habilidade � de alcance.
	// O padr�o � 14 (monstros + pets + homun)
	skillrange_by_distance: 14

	// O alcance da arma equipada deve ignorar o alcance da habilidade
	//definida em skill_db para a maioria das habilidades que utilizam
	//armas?
	// NOTA: Habilidades afetadas por esta op��o s�o aquelas cujo o
	//alcance na skill_db � negativo.
	// Note que ao menos que monster_ai&0x400 seja definido, o alcance
	//de todas as habilidades ser� 9 para monstros.
	skillrange_from_weapon: 0

	// Jogadores fora de combate poder�o causar danos atrav�s de
	//habilidades de �rea?
	// Caso definido como sim, metoros, nevasca e outras habilidades
	//de �rea n�o ter�o efeito caso o jogador esteja fora de combate:
	// dormindo, congelado e etc...
	skill_caster_check: true

	// Habilidades de ch�o devem ser removidas assim que quem as
	//conjura morre?
	clear_skills_on_death: 0

	// Habilidades de ch�o devem ser removidas assim que quem as conjura
	//sa� do mapa onde a habilidade foi conjurada?
	clear_skills_on_warp: 15

	//Definindo para true ir� substituir o modo de alvo de habilidades
	//"de ch�o" com a flag x01 para "Sem Oponentes"
	// As duas habilidades afetadas por padr�o s�o Escudo Sagrado e
	//Escudo M�gico.
	// Caso habilitado, estas duas habilidades n�o proteger�o mais,
	//somente aliados
	defunit_not_enemy: false

	// Habilidades d�o pelo menos 'hits' de dano quando n�o falham/s�o
	//bloqueadas?
	// Por exemplo, Lan�as de Fogo sempre possuem causar�o pelo menos o
	//dano do n�mero de lan�as contra plantas?
	//Valores (some quando achar apropriado): 1 para ataques baseados
	//em arma, 2 para ataques m�gicos, 4 ataques variados.
	skill_min_damage: 6

	// Taxa de delay do combo dos monges
	combo_delay_rate: 100

	// Usar um tipo alternativa da habilidade Contra-Ataque?
	// Para os personagens nos quais esta configura��o afeta,
	//100% cr�tico, caso contr�rio s�o desconsideradas
	//DEF e HIT+20, CRI*2
	auto_counter_type: 15

	// Habilidades de ch�o podem ser substituidas sobre outras?
	// Por padr�o, habilidades com UF_NOREITERATION definidas n�o podem
	//ser colocadas sobre outras habilidades, esta configura��o ir�
	//substituir isto. (skill_unit_db)
	skill_reiteration: 0

	// Habilidades de ch�o N�O podem ser colocadas em baixo/perto de
	//jogadores/monstros?
	// Se definida, somente habilidades com UF_NOFOOTSET
	//ser�o afetadas (skill_unit_db)
	skill_nofootset: 1

	// Armadilhas (armadilhas de ca�ador + p�ntano dos mortos) devem
	//mudar seu alvo para "todos" dentro do campo gvg/pvp?
	// Padr�o nos servidores oficiais: yes para armadilhas de jogadores
	gvg_traps_target_all: 1

	// Algumas configura��es de armadilhas.
	//(Se Necess�rio Some os valores Desejados):
	// 1: Armadilhas s�o invis�veis para quem entra na vis�o delas.
	//Quando indefinida, todas as armadilhas s�o vistas a todo tempo.
	// (Armadilhas invis�veis podem ser reveladas atr�ves da habilidade
	//Alerta)
	traps_setting: 0

	// Restri��es aplicadas � habilidade Criar Planta Carn�vora
	//(Se Necess�rio Some os valores Desejados)
	// 1: Habilitar jogadores a atacar as plantas fora da �rea de dano.
	// 2: Desabilitar diferentes tipos ao mesmo tempo
	// Exemplo: proibir invocar qualquer coisa exceto hidras quando j�
	//h� uma hidra
	summon_flora_setting: 3

	// Caso a can��o seja cancelada ou terminada ou o jogador saia da
	//�rea, continuar� com o efeito por um curto per�odo de tempo, o
	//jogador poder� tocar a can��o novamente para resetar  o efeito da
	//habilidade?
	// 0: N�o, dever� aguardar 20 segundos AP�S perder o efeito da
	//habilidade (Aegis)
	// 1: Sim, poder� tocar novamente em seguida para resetar o efeito
	//da habilidade (eathena)
	song_timer_reset: 0

	// Habilidades colocadas no ch�o checar�o paredes
	// (Faz com que Nevasca/Ira de Thor/etc quando conjuradas pertas de
	//uma parede, n�o ir� causar� dano do outro lado)
	skill_wall_check: true

	// Quando escondido, a parede � verificada ou n�o?
	// Nota: Quando a habilidade n�o faz a checagem por paredes, voc�
	//sempre ser� considerado como se tivesse uma parade pr�xima a
	//voc� (voc� ter� a velocidade baseada na parede). 
	//  Some as configura��es requeridas, ser atacado sempre tira
	//o efeito de esconderijo.
	// 
	// 0 = n�o verificar paredes
	// 1 = Procurar por paredes
	// 2 = Esconderijo n�o � cancelado quando atacado
	// 4 = Esconderijo n�o � cancelado quando usando habilidades
	player_cloak_check_type: 1
	monster_cloak_check_type: 4

	// N�o permitir colocar habilidades ilimitadas no ch�o ao mesmo tempo
	land_skill_limit: 9

	//Determine que tipo de mensagem ser� exibida quando uma
	//habilidade falhar:
	// 1 - Desabilitar todas as mensagens.
	// 2 - Desabilitar mensagens devido a delay.
	// 4 - Desabilitar mensagens de M�os Leves
	// 8 - Desabilitar mensagens de Envenenar
	display_skill_fail: 0

	// Um jogador numa sala de chat (in-game) pode ser teleportado em
	//um portal?
	chat_warpportal: false

	// O que a habilidade "Sentido Sobrenatural" ir� exibir nos
	//campos de defesa?
	// 0: N�o exibir defesa
	// 1: Base def
	// 2: Vit/Int def
	// 3: Ambos (Padr�o)
	sense_type: 1

	// Qual estilo ofensivo deve ser usado?
	// 0 = Estilo Aegis (ataque �nico com v�rios hits)
	// 1 = Estilo Athena (ataques m�ltiplos consecutivos)
	finger_offensive_type: 0

	// Configura��es de Crux Magnum (N�o mexa se n�o souber)
	// Se definida para no, o intervalo de hits � aumentado baseado na
	//quantidade de monstros vivos na mesma c�lula.
	// (significa que quando h� monstros na mesma c�lula, eles n�o
	//receber�o todos os hits)
	gx_allhit: false

	// Tipo de exibi��o do Crux Magnum (Padr�o: 1)
	// 0: Personagem Amarelado
	// 1: Personagem Esbranqui�ado
	gx_disptype: 1

	// M�xima diferen�a entre n�veis para usar a habilidade Reden��o
	devotion_level_difference: 10

	// Se no, ent�o pode-se usar habilidades de conjunto sozinho.
	player_skill_partner_check: true

	// Tipo de remo��o de armadilha
	// 0 = Sistema Aegis : Retorna com 1 'Armadilha'
	// 1 = Sistema Athena : Retorna com todos os itens gastos para
	//fazer a armadilha
	skill_removetrap_type: 0

	// Quando se usa arco para atacar por tr�s h� uma penalidade
	//de 50% no dano?
	backstab_bow_penalty: true

	// Quantas vezes voc� pode tentar furtar um monstro.
	// Nota: Isto ajuda a evitar o exploit de furtos em monstros
	//com itens raros
	// Use 0 para desabilitar (o valor m�ximo permitido � 255)
	skill_steal_max_tries: 0

	// Arruaceiros podem plagear habilidades de classes avan�adas
	// 0 = sem restri��es
	// 1 = somente desordeiros podem plagear habilidades avan�adas     
	// 2 = habilidades avan�adas n�o podem ser plageadas por
	//nenhuma classe
	// Configura��o dos servidores oficiais: 2
	copyskill_restrict: 2

	// A habilidade Frenesi cancela buffs do jogador quando usada?
	berserk_cancels_buffs: false

	// Quantidade e N�vel da Cura m�ximos. Quando algu�m conjura
	//cura neste n�vel ou
	// maior, a f�rmula da cura � ignorada e este valor � usado no lugar.
	max_heal: 9999
	max_heal_lv: 11

	// Habilitar jogadores de pular o menu quando utilizar Teleporte n�vel 1
	// O menu cont�m apenas duas op��es. "Aleat�rio" e "Cancelar"
	skip_teleport_lv1_menu: false

	// Permitir o uso de habilidades de Mestre Taekwon independente
	//do dia ser apropriado (Solar/Luar/Estelar) ?
	allow_skill_without_day: false

	// Permitir o uso de habilidades m�gicas de Espiritualistas
	//(Esma, Eswoo, etc) em jogadores?
	allow_es_magic_player: false

	// Taxa da habilidade Milagre Solar, Lunar e Estelar (100% = 10000)
	sg_miracle_skill_ratio: 2

	// Dura��o da habilidade Milagre Solar, Lunar e Estelar em
	//milisegundos
	sg_miracle_skill_duration: 3600000

	// Taxa da habilidade Anjo Solar, Lunar e Estelar (100% = 10000)
	sg_angel_skill_ratio: 10

	// Habilidades em que bHealPower afeta
	// 1: Cura, 2: Santu�rio, 4: Arremessar Po��o, 8: Arremessar Po��o
	//Compacta, 16: Ma�� de Idun
	skill_add_heal_rate: 7

	// O dano da habilidade Terremoto com um alvo �nico na tela �
	//pass�vel de ser refletido?
	// Nota: Em servidores oficiais, o Terremoto pode ser refletido
	//quando h� somente um alvo na tela,
	// que provavelmente � um exploit para ca�ar MVPs.
	eq_single_target_reflectable: true

	// Em servidores oficiais, voc� receber� dano de Reflex�o e Destino
	//das Cartas mesmo com status de invenc�vel.
	// Quando esta configura��o � habilitada, permite voc� de ser imune
	//a qualquer tipo de dano, incluindo os citados anteriormente.
	// (O n�mero ser� exibido mas o valor atual n�o)
	invincible_nodamage: false

	// Dan�ando durante a troca de armas
	// Nos servidores oficiais, uma corre��o � feita para previnir o
	//cancelamento de habilidades musicais durante a troca de armas
	// Padr�o: yes
	dancing_weaponswitch_fix: true

	// Skill Trap Type (GvG)
	// 0: (official) Traps in GvG only make player stop moving after its walk path is complete, and it activates other traps on the way.
	// 1: Traps in GvG make player stop moving right when stepping over it.
	skill_trap_type: 0

	// O dado de armadilhas pode ser refletido?
	trap_reflect: true

	// Tipos de Armadilhas (GvG)
	// 0: (oficial) Armadilhas usadas em GvG s� far�o o jogador parar de
	//se mover depois de sua trajet�ria completa, e ele ativa outras
	//armadilhas no caminho.
	// 1: Armadilhas usadas em GvG far�o o jogador parar de se mover
	//ao pisar sobre ela.
	skill_trap_type: 0

	// N�vel m�ximo para habilidades de monstros
	// Nota: Se seus MVPs estiverem muito dif�ceis, reduza o valor em 10.
	mob_max_skilllvl: 100

	// �rea de rea��o do Impacto de Tyr
	// 0: Utilizar a linha de configura��o de servidores oficiais.
	// 1: Utilizar a linha de configura��o sem Bug
	// 2-20: �rea de rea��o/dano personalizada
	//(2 = 5x5, 3 = 7x7, 4 = 9x9, ..., 20 = 41x41)
	// Nota: Se voc� bater o alvo fora da �rea, o alvo apenas ser�
	//atingido uma vez e n�o ter� o dano agrupado.
	bowling_bash_area: 0

	// Em servidores oficiais a Nevasca consiste em 81 unidades de
	//dano, por 3x3 de dist�ncia do centro em rela��o � tela.
	// Caso voc� desabilite esta op��o, o empurr�o da Nevasca dentro das
	//c�lulas descritas ser�o totalmente aleat�rios. (eAthena Padr�o)
	stormgust_knockback: true

	// Magic Rod's animation behavior
	// 0 : (official) Magic Rod's animation occurs every time it is used.
	// 1 : Magic Rod's animation would not occur unless a spell was absorbed. (old behavior)
	magicrod_type: 0

	// Exibir uso de habilidades no console? (somente depura��o)
	skill_log: false
}
