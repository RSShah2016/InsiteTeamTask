import { Component, OnInit } from '@angular/core';
import { Game } from '../models/Game.class';

@Component({
    selector:'dropdown',
    templateUrl:'app/components/display-attendance.component.html',
   
})
export class DisaplyComponent implements OnInit
{
    
    game = Array<Game>();
    seasonId = Array<Number>();
    

    ngOnInit(): void {

        this.game = Array<Game>();
        this.game.push(new Game(3));
        this.game.push(new Game(4));
        this.game.push(new Game(5));
        this.game.push(new Game(12));
        this.game.push(new Game(3));
               
    }
}