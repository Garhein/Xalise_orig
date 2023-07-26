"use strict";

//#region Constantes globales : formulaires

const CONST_ID_FORM_CHECKBOX_SAISIE_SUITE = "#x-form-chk-saisie-suite";

//#endregion

//#region Constantes globales : conteneurs

const CONST_ID_MSG_ATTENTE_CONTAINER        = "#container-xalise-msg-attente";
const CONST_ID_MSG_ATTENTE_CONTENT          = "#content-xalise-msg-attente";

const CONST_ID_ALERTE_TEMPLATE_INFO         = "#alert-template-xalise-info";
const CONST_ID_ALERTE_TEMPLATE_SUCCESS      = "#alert-template-xalise-success";
const CONST_ID_ALERTE_TEMPLATE_DANGER       = "#alert-template-xalise-danger";
const CONST_CLASS_ALERTE_CONTENT            = ".alert-xalise-content";

//#endregion

//#region Constantes globales : énumérations

const CONST_ENUM_VALUE_MODE_GESTION_ARCHIVAGE             = 1;
const CONST_ENUM_VALUE_MODE_GESTION_ANNULATION_ARCHIVAGE  = 2;

//#endregion

//#region Fonctions globables

/**
 * Affiche une alerte d'information en haut de la page.
 * @author Xavier VILLEMIN
 * @param {string} contentHtml  Contenu de l'alerte.
 */
function Xalise_AfficherAlerteInfo(contentHtml) {
    Xalise_AfficherAlerte(CONST_ID_ALERTE_TEMPLATE_INFO, contentHtml);
}

/**
 * Affiche une alerte de validation en haut de la page.
 * @author Xavier VILLEMIN
 * @param {string} contentHtml  Contenu de l'alerte.
 */
function Xalise_AfficherAlerteValidation(contentHtml) {
    Xalise_AfficherAlerte(CONST_ID_ALERTE_TEMPLATE_SUCCESS, contentHtml);
}

/**
 * Affiche une alerte d'erreur en haut de la page.
 * @author Xavier VILLEMIN
 * @param {string} contentHtml  Contenu de l'alerte.
 */
function Xalise_AfficherAlerteErreur(contentHtml) {
    Xalise_AfficherAlerte(CONST_ID_ALERTE_TEMPLATE_DANGER, contentHtml);
}

/**
 * Affiche une alerte en haut de la page.
 * @author Xavier VILLEMIN
 * @param {string} selectorTemplate Identifiant du template à utiliser (# de sélection inclu).
 * @param {string} contentHtml      Contenu de l'alerte.
 */
function Xalise_AfficherAlerte(selectorTemplate, contentHtml) {
    let template = document.querySelector(selectorTemplate);
    let mainHtml = document.querySelector("main");
    let clone = document.importNode(template.content, true);

    $(CONST_CLASS_ALERTE_CONTENT, clone).html(contentHtml);
    mainHtml.prepend(clone);
}

/**
 * Ouverture d'une fenêtre de dialogue Bootstrap.
 * @author Xavier VILLEMIN
 * @param {string} modelID      Identifiant de la fenêtre de dialogue (# de sélection inclu).
 * @param {string} contentHtml  Contenu à insérer dans la fenêtre de dialogue.
 */
function Xalise_OuvrirDialogue(modalID, contentHtml) {
    let config = { keyboard: false, backdrop: 'static' };
    let modal  = document.querySelector(modalID);

    if (modal == null) {
        modal = $("<div id='" + modalID.substring(1) + "' class='modal'>");
        $("body").append(modal);
    }

    $(modal).html(contentHtml);

    let modalObj = new bootstrap.Modal($(modal), config);

    $(modal).modal('show');
}

/**
 * Fermeture et destruction d'une fenêtre de dialogue Bootstrap.
 * @author Xavier VILLEMIN
 * @param {string} modalID  Identifiant de la fenêtre de dialogue (# de sélection inclu).
 */
function Xalise_FermerDialogue(modalID) {
    let modal = document.querySelector(modalID);

    modal.addEventListener('hidden.bs.modal', event => {
        $(modal).modal('dispose');
        $(modal).remove();
    });

    $(modal).modal('hide');
}

/**
 * Exécution des traitements de fermeture d'une fenêtre de dialogue, vérifiant si
 * l'utilisateur souhaite réaliser une saisie à la suite.
 * @author Xavier VILLEMIN
 * @param {string}   formID                     Identifiant du formulaire HTML.
 * @param {Function} callback                   Callback exécuté dans tous les cas.
 * @param {Function} callbackFermeture          Callback à exécuter pour fermer la fenêtre de dialogue.
 * @param {Function} callbackRafraichissement   Callback à exécuter pour rafraîchir les données.
 * */
function Xalise_ExecuterFermetureDialogue(formID, callback, callbackFermeture, callbackRafraichissement) {
    let fermerDialogue = true;

    if ($(CONST_ID_FORM_CHECKBOX_SAISIE_SUITE, formID).length > 0 && $(CONST_ID_FORM_CHECKBOX_SAISIE_SUITE, formID).is(":checked")) {
        Xalise_ViderFormulaire(formID);
        fermerDialogue = false;
    }

    if (typeof callback === "function") {
        callback();
    }

    // Il faut rafraichir le répertoire, au cas où l'utilisateur à demandé une saisie à la suite mais annule la seconde saisie.
    if (typeof callbackRafraichissement === "function") {
        callbackRafraichissement();
    }

    if (fermerDialogue && typeof callbackFermeture === "function") {
        callbackFermeture();
    }
}

/**
 * Affichage du message d'attente indiquant qu'un traitement est en cours.
 * @author Xavier VILLEMIN
 * @param {string} message   Message à afficher (par défaut 'Traitement en cours...').
 */
function Xalise_AfficherMsgAttente(message) {
    // Message par défaut
    if (message === undefined || message === null || message === "") {
        message = "Traitement en cours...";
    }

    $("span", CONST_ID_MSG_ATTENTE_CONTENT).html(message);
    $(CONST_ID_MSG_ATTENTE_CONTAINER).fadeIn("fast");
}

/**
 * Cache le message d'attente indiquant qu'un traitement est en cours.
 * @author Xavier VILLEMIN 
 */
function Xalise_CacherMsgAttente() {
    // Le retrait du message est réalisé après que le conteneur ait été caché, sinon il disparaît
    // avant que le conteneur soit réellement caché
    $(CONST_ID_MSG_ATTENTE_CONTAINER).fadeOut("fast", function () { $("span", CONST_ID_MSG_ATTENTE_CONTENT).html(""); });
}

/**
 * TODO: Xalise_ViderFormulaire
 * Vide les champs d'un formulaire de saisie.
 * @author Xavier VILLEMIN
 * @param {object} eltButton
 * */
function Xalise_ViderFormulaire(eltButton) {
    let form = $(eltButton).closest('form');

    $("input[type='text']:not(.nePasVider)", form).val("");
    $("input[type='hidden'][value!=false]:not(.nePasVider)", form).val("");
    $("input[type='checkbox']:not(.nePasVider)", form).attr("checked", false);
    $("textarea:not(.nePasVider)", form).val("");

    form.find("select:not(.nePasVider)").each(function () {
        if ($(this).attr("multiple") != undefined) {
            $("option", $(this)).prop('selected', false);
        }
        else {
            $("option:first", $(this)).prop('selected', true);
        }
    });
}

//#endregion

//#region Gestion des thèmes GED

const CONST_ID_REP_THEME_GED_MODAL              = "#modal-rep-theme-ged";
const CONST_ID_REP_THEME_GED_CONTAINER_LIST     = "#container-rep-theme-ged-list";
const CONST_ID_FORM_REP_THEME_GED_EDIT          = "#form-rep-theme-ged-edit";
const CONST_ID_FORM_REP_THEME_GED_CRITERES      = "#form-rep-theme-ged-criteres";

/**
 * Exécute la recherche et actualise la liste des thèmes GED.
 * @author Xavier VILLEMIN
 */
function ThemeGED_ActualiserRepertoire() {
    Xalise_AfficherMsgAttente("Recherche en cours...");

    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/ThemeGED/ActualiserRepertoire",
        dataType: "html",
        type: "GET",
        data: $(CONST_ID_FORM_REP_THEME_GED_CRITERES).serialize()
    })
        .done(function (data, textStatus, jqXHR) {
            $(CONST_ID_REP_THEME_GED_CONTAINER_LIST).html(data);
            Xalise_CacherMsgAttente();
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            //TODO: gestion du 'fail'
        })
        .always(function () {
            Xalise_CacherMsgAttente();
        });
}

/**
 * Fermeture de la fenêtre de dialogue de gestion d'un thème GED.
 * @author Xavier VILLEMIN
 */
function ThemeGED_Fermer() {
    Xalise_FermerDialogue(CONST_ID_REP_THEME_GED_MODAL);
}

/**
 * Affiche la fenêtre de dialogue de création/modification d'un thème.
 * @author Xavier VILLEMIN
 * @param {int} modeOuverture   Mode d'ouverture de la fenêtre de dialogue.
 * @param {int} themeID         Identifiant du thème à afficher.
 */
function ThemeGED_AfficherTheme(modeOuverture, themeID) {
    Xalise_AfficherMsgAttente();

    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/ThemeGED/AfficherTheme",
        dataType: "html",
        type: "GET",
        data: {
            modeOuverture: modeOuverture,
            themeID: themeID
        }
    })
        .done(function (data, textStatus, jqXHR) {
            Xalise_OuvrirDialogue(CONST_ID_REP_THEME_GED_MODAL, data);
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            //TODO: gestion du 'fail'
        })
        .always(function () {
            Xalise_CacherMsgAttente();
        });
}

/**
 * Enregistrement (création ou modification) d'un thème GED.
 * @author Xavier VILLEMIN
 */
function ThemeGED_EnregistrerTheme() {
    Xalise_AfficherMsgAttente("Enregistrement en cours...");

    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/ThemeGED/EnregistrerTheme",
        dataType: "json",
        type: "POST",
        data: $(CONST_ID_FORM_REP_THEME_GED_EDIT).serialize()
    })
        .done(function (data, textStatus, jqXHR) {
            if (data.AvecErreur) {
                //TODO: gestion de l'erreur pour 'ThemeGED_EnregistrerTheme'
            }
            else {
                Xalise_ExecuterFermetureDialogue(
                    CONST_ID_FORM_REP_THEME_GED_EDIT,
                    function () {
                        Xalise_AfficherAlerteValidation(data.messageSucces);
                    },
                    function () {
                        ThemeGED_Fermer();
                    },
                    function () {  
                        ThemeGED_ActualiserRepertoire();
                    }
                );
            }
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            //TODO: gestion du 'fail'
        })
        .always(function () {
            Xalise_CacherMsgAttente();
        });
}

/**
 * Affiche la fenêtre de dialogue de gestion de l'archivage d'un thème GED.
 * @author Xavier VILLEMIN
 * @param {int} modeGestion     Mode de gestion de l'archivage.
 * @param {int} themeID         Identifiant du thème.
 */
function ThemeGED_AfficherDialogueGestionArchivage(modeGestion, themeID) {
    Xalise_AfficherMsgAttente();

    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/ThemeGED/AfficherDialogueGestionArchivage",
        dataType: "html",
        type: "GET",
        data: {
            modeGestion: modeGestion,
            themeID: themeID
        }
    })
        .done(function (data, textStatus, jqXHR) {
            Xalise_OuvrirDialogue(CONST_ID_REP_THEME_GED_MODAL, data);
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            //TODO: gestion du 'fail'
        })
        .always(function () {
            Xalise_CacherMsgAttente();
        });
}

/**
 * Exécute les traitements d'archivage d'un thème GED.
 * @author Xavier VILLEMIN
 * @param {int} modeGestion     Mode de gestion de l'archivage.
 * @param {int} themeID         Identifiant du thème.
 * */
function ThemeGED_ExecuterGestionArchivage(modeGestion, themeID) {
    let msgAttente = "";

    if (modeGestion === CONST_ENUM_VALUE_MODE_GESTION_ARCHIVAGE) {
        msgAttente = "Archivage en cours...";
    }
    else {
        msgAttente = "Annulation de l'archivage en cours...";
    }

    Xalise_AfficherMsgAttente(msgAttente);
    ThemeGED_Fermer();

    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/ThemeGED/ExecuterGestionArchivage",
        dataType: "json",
        type: "POST",
        data: {
            modeGestion: modeGestion,
            themeID: themeID
        }
    })
        .done(function (data, textStatus, jqXHR) {
            if (data.AvecErreur) {
                // TODO: gestion de l'erreur pour 'ThemeGED_ArchiverTheme'
                // Message affiché dans un container toujours présent sur toutes les pages (pas de dialogue) mais qui disparaît au clic sur une icône
                // Faire générique
            }
            else {
                Xalise_AfficherAlerteValidation(data.messageSucces);
                ThemeGED_ActualiserRepertoire();
            }
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            // TODO: gestion du 'fail'
        })
        .always(function () {
            Xalise_CacherMsgAttente();
        });
}






















/**
 * Suppression d'un thème.
 * @author Xavier VILLEMIN
 * @param {int} themeID
 */
function Theme_Supprimer(themeID) {
    if (themeID <= 0) {

    }
    else {

    }
}

//#endregion