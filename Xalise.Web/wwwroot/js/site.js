"use strict";

//#region Fonctions globables

/**
 * Ouverture d'une fenêtre de dialogue bootstrap.
 * @author Xavier VILLEMIN
 * @param {string} selector
 * @param {string} contentHtml
 */
function Xalise_OpenModal(selector, contentHtml) {
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
function Xalise_CloseModal(selector) {
    let modal = document.querySelector(selector);

    modal.addEventListener('hidden.bs.modal', event => {
        $(modal).modal('dispose');
        $(modal).remove();
    });

    $(modal).modal('hide');
}

//#endregion

//#region Gestion des thèmes

let selectorThemeModalID    = '#div-modal-theme-edit';
let selectorThemeEditFormID = '#form-theme-edit';

/**
 * Fermeture de la fenêtre de dialogue d'édition d'un thème.
 * @author Xavier VILLEMIN
 */
function Theme_Fermer() {
    Xalise_CloseModal(selectorThemeModalID);
}

/**
 * Création ou modification d'un thème.
 * @author Xavier VILLEMIN
 * @param {int} themeID
 */
function Theme_Editer(themeID) {
    $.ajax({
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        url: "/Repertoires/Theme/Edit",
        dataType: "html",
        type: "GET",
        data: {
            themeID: themeID
        }
    })
        .done(function (data, textStatus, jqXHR) {
            Xalise_OpenModal(selectorThemeModalID, data);
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            
        })
        .always(function () {
            
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