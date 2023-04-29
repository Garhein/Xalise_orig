"use strict";

//#region Déclarations et fonctions globables

const selectorSaisieSuiteID         = '#ui-chk-saisie-suite';
const selectorContainerMsgAttenteID = '#div-container-xalise-msg-attente';
const selectorMsgAttenteID          = '#div-xalise-msg-attente';

/**
 * Ouverture d'une fenêtre de dialogue bootstrap.
 * @author Xavier VILLEMIN
 * @param {string} selector
 * @param {string} contentHtml
 */
function Xalise_OuvrirDialogue(selector, contentHtml) {
    let config = { keyboard: false, backdrop: 'static' };
    let modal  = document.querySelector(selector);

    if (modal == null) {
        modal = $("<div id='" + selector.substring(1) + "' class='modal'>");
        $("body").append(modal);
    }

    $(modal).html(contentHtml);

    let modalObj = new bootstrap.Modal($(modal), config);

    $(modal).modal('show');
}

/**
 * Fermeture et destruction d'une fenêtre de dialogue bootstrap.
 * @author Xavier VILLEMIN
 * @param {string} selector
 */
function Xalise_FermerDialogue(selector) {
    let modal = document.querySelector(selector);

    modal.addEventListener('hidden.bs.modal', event => {
        $(modal).modal('dispose');
        $(modal).remove();
    });

    $(modal).modal('hide');
}

/**
 * Affichage et retrait du message d'attente.
 * @author Xavier VILLEMIN
 * @param {string} message
 */
function Xalise_GererMsgAttente(message) {
    // Message par défaut
    if (message === undefined || message === null) {
        message = "Traitement en cours...";
    }

    if (message != null && message != "") {
        $("span", selectorMsgAttenteID).html(message);
        $(selectorContainerMsgAttenteID).fadeIn("slow");
    }
    else {
        // Le retrait du message est réalisé après que le conteneur ait été caché, sinon il disparaît
        // avant que le conteneur soit réellement caché
        $(selectorContainerMsgAttenteID).fadeOut("slow", function () { $("span", selectorMsgAttenteID).html(""); });
    }
}

//#endregion

//#region Gestion des thèmes

const selectorThemeModalID    = '#div-modal-theme-edit';
const selectorThemeEditFormID = '#form-theme-edit';

/**
 * Fermeture de la fenêtre de dialogue d'édition d'un thème.
 * @author Xavier VILLEMIN
 */
function Theme_Fermer() {
    Xalise_FermerDialogue(selectorThemeModalID);
}

/**
 * Création ou modification d'un thème.
 * @author Xavier VILLEMIN
 * @param {int} modeOuverture
 * @param {int} themeID
 */
function Theme_Editer(modeOuverture, themeID) {
    Xalise_GererMsgAttente();

    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/Theme/Edit",
        dataType: "html",
        type: "GET",
        data: {
            modeOuverture: modeOuverture,
            themeID: themeID
        }
    })
        .done(function (data, textStatus, jqXHR) {
            Xalise_OuvrirDialogue(selectorThemeModalID, data);
        })
        .fail(function (jqXHR, textStatus, errorThrown) {

        })
        .always(function () {
            Xalise_GererMsgAttente("");
        });
}

/**
 * Enregistrement (création ou modification) d'un thème.
 * @author Xavier VILLEMIN
 */
function Theme_Enregistrer() {
    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/Theme/Save",
        dataType: "json",
        type: "POST",
        data: $(selectorThemeEditFormID).serialize()
    })
        .done(function (data, textStatus, jqXHR) {
            Theme_Fermer();
            location.reload();
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

/**
 * Gestion de l'archivage ou de l'activation d'un thème.
 * @author Xavier VILLEMIN
 * @param {int}     themeID
 * @param {boolean} archiverTheme
 */
function Theme_GererArchivage(themeID, archiverTheme) {

}

//#endregion