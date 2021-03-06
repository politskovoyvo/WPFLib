var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AuthGuard } from '../../Autification/ModelSecuriti/AuthGuard';
import { AuthInventar } from '../../Autification/ModelSecuriti/AuthInventarization';
import { AppModule } from './Otdel/OtdelFull';
import { InventarModule } from './Inventarization/Inventarka';
var appRoutes = [
    {
        path: 'admin',
        loadChildren: function () { return AppModule; },
        canLoad: [AuthGuard]
    },
    {
        path: 'inventarization',
        loadChildren: function () { return InventarModule; },
        canLoad: [AuthInventar]
    }
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = __decorate([
        NgModule({
            imports: [
                RouterModule.forRoot(appRoutes, {
                    enableTracing: false // <-- debugging purposes only
                })
            ],
            exports: [
                RouterModule
            ]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());
export { AppRoutingModule };
//# sourceMappingURL=RoutingMain.js.map