/*-----------------------------------------------------------------*\
|              ____                     _                           |
|             /    |                   | |_                         |
|            /     |_ __ ____  __ _  __| |_  __ _                   |
|           /  /|  | '__/  __|/ _` |/ _  | |/ _` |                  |
|          /  __   | | |  |__  (_| | (_| | | (_| |                  |
|         /  /  |  |_|  \____|\__,_|\__,_|_|\__,_|                  |
|        /__/   |__|   Ragnarok - Npc Script                        |
|                                                                   |
+-------------------------------------------------------------------+
| - Author: Sem informa��o precisa                                  |
| - Version: Spell Master                                           |
| - Info: Aluguel de Montarias para Cavaleiro/Lorde. &              |
          Templ�rio/Paladino.                                       |
\*-----------------------------------------------------------------*/

// ------------------------------------------------------------------
// - [ Cavaleiro e Lorde ] -
// ------------------------------------------------------------------
prontera,55,350,5	script	Criador de Pecopecos#kntMount	8W_SOLDIER,{
	if (Upper == 0) { .@price = 2500; }
	if (Upper == 1) { .@price = 5000; }
	if (Upper == 2) { .@price = 5000; }
	mes("[Criador de Pecopecos]");
	if (BaseJob == Job_Knight || BaseJob == Job_Knight2 || BaseJob == Job_Lord_Knight || BaseJob == Job_Lord_Knight2) {
		mes("Bom-dia honor�vel Cavaleiro gostaria de alugar um Pecopeco?\n"
			"Voc� precisa ter a Habilidade Montaria e apenas " + .@price + " Zeny sobrando.");
		next;
		switch (select("Alugar Peco Peco", "Cancelar")) {
			case 1:
			if (Zeny < .@price) {
				mes("[Criador de Pecopecos]\n"
					"Sinto muito mas voc� n�o tem zenys o suficiente.");
				close;
			} else if (!getskilllv(KN_RIDING)) {
				mes("[Criador de Pecopecos]\n"
					"Voc� n�o pode usar meus servi�os at� aprender a habilidade Montaria.");
				close;
			} else if (checkmount()) {
				mes("[Criador de Pecopecos]\n"
					"Mas voc� j� est� montado em um Pecopeco.");
				close;
			} else if (hascashmount()) {
				mes("[Criador de Pecopecos]\n"
					"Por favor remova sua montaria atual.");
				close;
			}
			Zeny -= .@price;
			setmount(MOUNT_PECO);
			close;
			case 2:
			mes("[Criador de Pecopecos]\n"
				"Bem ent�o, tenha um dia bom.");
			close;
		}
	} else {
		mes("Me desculpe mas o aluguel de pecopecos s� est� dispon�vel para cavaleiros e lordes.");
		close;
	}
}

// ------------------------------------------------------------------
// - [ Templario e Paladino ] -
// ------------------------------------------------------------------
prontera,232,318,3	script	Criador de Pecopecos#cruMount	8W_SOLDIER,{
	if (Upper==0) .@price = 3500;
	if (Upper==1) .@price = 7000;
	if (Upper==2) .@price = 7000;

	mes("[PecoPeco Breeder]");
	if (BaseJob == Job_Crusader || BaseJob == Job_Crusader2 || BaseJob == Job_Paladin || BaseJob == Job_Paladin2) {
		mes("N�s possu�mos um Pecopeco especial preparado para voc�.\n"
			"Para adquirir um Pecopeco s�o necess�rios " + .@price + " Zeny.");
		next;
		switch (select("Alugar a PecoPeco", "Sair")) {
			case 1:
			if (Zeny < .@price) {
				mes("[Criador de Pecopecos]\n"
					"Voc� n�o possui a quantidade de zenys suficientes.\n"
					"Se voc� quiser um Pecopeco por favor me traga " + .@price + " zenys...");
				close;
			} else if (!getskilllv(KN_RIDING)) {
				mes("[Criador de Pecopecos]\n"
					"Voc� deve primeiro aprender a como montar um Pecopeco,\n"
					"ap�s isso eu poderei alugar um para voc�.");
				close;
			} else if (checkmount()) {
				mes("[Criador de Pecopecos]\n"
					"Voc� j� est� montado em uma montaria.");
				close;
			} else if (hascashmount()) {
				mes("[Criador de Pecopecos]\n"
					"Por favor remova sua montaria atual.");
				close;
			}
			Zeny -= .@price;
			setmount(MOUNT_PECO);
			close;
			case 2:
			mes("[PecoPeco Breeder]\n"
				"Nos vemos por ai.");
			close;
		}
	} else {
		mes("Me desculpe mas o aluguel de montaria s� est� dispon�vel para Templ�rios e Paladinos.");
		close;
	}
}
