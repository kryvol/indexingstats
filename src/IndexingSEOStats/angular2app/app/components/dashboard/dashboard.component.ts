﻿import { DomainService } from '../../services/domain.service';
import { OnInit, OnDestroy, Component, NgModule, ViewEncapsulation } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { Domain } from '../../interfaces/domain.interface';
import { Observable } from 'rxjs/Observable';
import { Subscription } from 'rxjs/Subscription';
import { StatsComponent } from '../stats/stats.component';
import { SettingsComponent } from '../settings/settings.component';
import { NotifiationsComponent } from '../notifications/notification.component';

@Component({
    selector: 'dashboard',
    template: require('./dashboard.component.html')
})

export class DashboardComponent implements OnInit, OnDestroy {
    
    constructor() {
        
    }

    ngOnInit() {
        
    }

    ngOnDestroy() {
        
    }

    public isActive: boolean = true;
      
}