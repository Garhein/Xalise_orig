"use strict";

//#region Déclarations et fonctions globables

const selectorSaisieSuiteID         = '#x-chk-saisie-suite';
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
        $(selectorContainerMsgAttenteID).fadeIn("fast");
    }
    else {
        // Le retrait du message est réalisé après que le conteneur ait été caché, sinon il disparaît
        // avant que le conteneur soit réellement caché
        $(selectorContainerMsgAttenteID).fadeOut("fast", function () { $("span", selectorMsgAttenteID).html(""); });
    }
}

/**
 * Vide les champs d'un formulaire de saisie.
 * @author Xavier VILLEMIN
 * @param {string} selectorForm
 * */
function Xalise_ViderFormulaire(selectorForm) {
    let form = $(selectorForm);

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

const selectorThemeGEDModalID      = '#div-modal-theme-ged-edit';
const selectorThemeGEDEditFormID   = '#form-theme-ged-edit';

/**
 * Fermeture de la fenêtre de dialogue d'édition d'un thème.
 * @author Xavier VILLEMIN
 */
function ThemeGED_Fermer() {
    Xalise_FermerDialogue(selectorThemeGEDModalID);
}

/**
 * Création ou modification d'un thème.
 * @author Xavier VILLEMIN
 * @param {int} modeOuverture
 * @param {int} themeID
 */
function ThemeGED_Editer(modeOuverture, themeID) {
    Xalise_GererMsgAttente();

    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/ThemeGED/Edit",
        dataType: "html",
        type: "GET",
        data: {
            modeOuverture: modeOuverture,
            themeID: themeID
        }
    })
        .done(function (data, textStatus, jqXHR) {
            Xalise_GererMsgAttente("");
            Xalise_OuvrirDialogue(selectorThemeGEDModalID, data);
        })
        .fail(function (jqXHR, textStatus, errorThrown) {

        });
}

/**
 * Enregistrement (création ou modification) d'un thème.
 * @author Xavier VILLEMIN
 */
function ThemeGED_Enregistrer() {
    Xalise_GererMsgAttente("Enregistrement en cours...");

    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/ThemeGED/Save",
        dataType: "json",
        type: "POST",
        data: $(selectorThemeGEDEditFormID).serialize()
    })
        .done(function (data, textStatus, jqXHR) {
            if (data.AvecErreur) {

            }
            else {
                if ($(selectorSaisieSuiteID, selectorThemeGEDEditFormID).is(":checked")) {
                    Xalise_ViderFormulaire(selectorThemeGEDEditFormID);
                }
                else {
                    ThemeGED_Fermer();
                    location.reload();
                }
            }
        })
        .always(function () {
            Xalise_GererMsgAttente("");
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