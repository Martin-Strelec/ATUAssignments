import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Week 2 - To Do List - Martin Strelec S00256070';

  thingsToDo = [
    "Learn JavaScript",
    "Learn Angular",
    "Learn Redux"
  ];

  thingsCompleted=[];

  summary():string {
    return `${this.thingsToDo.length} to do / ${this.thingsCompleted.length} done`
  }
}
