﻿import { FullSetting } from './FullSetting'


//Общепринятая молдель отправки даты на сервер
export class DateModel {
    public validation: boolean = true;

    public messageerror: string;

    //С какой даты
    public D85DateStart: number;
    //По какую дату
    public D85DateFinish: number;

    valid(): boolean {
        if (this.D85DateStart == null || this.D85DateFinish == null) {
            this.messageerror = 'Не все даты введены для запроса!!!';
            return this.validation = false;
        }
        if (this.D85DateStart > this.D85DateFinish) {
            this.messageerror = 'Дата начала не может быть больше окончания!!!';
            return this.validation = false;
        }
        this.messageerror = null;
        return this.validation = true;
    }
    ///Конвертация даты в модели BDkOut
    convertdate(setting: FullSetting, dateStart: number, dateFinis: number) {
        var ds = new Date(dateStart);
        var df = new Date(dateFinis);
        setting.ParametrBdkOut.D85DateStart = `/Date(${ds.getTime()})/`;
        setting.ParametrBdkOut.D85DateFinish = `/Date(${df.getTime()})/`;
    }

    ///Конвертация даты в модели Решения
    convertdateresh(setting: FullSetting, dateStart: number, dateFinis: number) {
        var ds = new Date(dateStart);
        var df = new Date(dateFinis);
        setting.ParametrReshen.D85DateStart = `/Date(${ds.getTime()})/`;
        setting.ParametrReshen.D85DateFinish = `/Date(${df.getTime()})/`;
    }
}