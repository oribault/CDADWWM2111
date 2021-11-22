<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="result EST_DU_TYPE NOMBRE" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2para="" F2lignes="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="result EST_DU_TYPE NOMBRE" code="1#NOMBRE#result"/>
        <item algoitem="add10 EST_DU_TYPE NOMBRE" code="1#NOMBRE#add10"/>
        <item algoitem="substr5 EST_DU_TYPE NOMBRE" code="1#NOMBRE#substr5"/>
        <item algoitem="multi7 EST_DU_TYPE NOMBRE" code="1#NOMBRE#multi7"/>
        <item algoitem="div2 EST_DU_TYPE NOMBRE" code="1#NOMBRE#div2"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="LIRE result" code="2#result#pasliste"/>
        <item algoitem="AFFICHERCALCUL result +10" code="20#result +10#1"/>
        <item algoitem="AFFICHERCALCUL result - 5" code="20#result - 5#1"/>
        <item algoitem="AFFICHERCALCUL result*7" code="20#result*7#1"/>
        <item algoitem="AFFICHERCALCUL result /2" code="20#result /2#0"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
