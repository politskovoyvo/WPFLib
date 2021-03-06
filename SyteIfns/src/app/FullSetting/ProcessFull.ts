﻿//Работа с интерфейсом блокировка сообщения и ТД MVVM
export class BlocsInfoButton {

    blocks: boolean = false;
    messagestatus: string;

    blockbuttonreshen(message: string = null) {
        if (!this.blocks) {
            this.blocks = true;
            this.messagestatus = 'Запущен процесс по выставлению Решений!!!';
        } else {
            this.blocks = false;
            this.messagestatus = message;
        }
    }

    blockbuttonincass(message: string = null) {
        if (!this.blocks) {
            this.blocks = true;
            this.messagestatus = 'Запущен процесс по выставлению Инкассовых поручений!!!';
        } else {
            this.blocks = false;
            this.messagestatus = message;
        }
    }

    blockprocedure(message: string) {
        if (!this.blocks) {
            this.blocks = true;
            this.messagestatus = 'Запущен процесс по '+message+'!!!';
        } else {
            this.blocks = false;
            this.messagestatus = message;
        }
    }

    serverrestmessage(message: string) {
        this.messagestatus = message;
    }
}