// Zac Rice
// Date Revised: 11/9/2022
// Title: Mad Lib end point
// Description: Redo the Mad Lib project but as an end point with api
// Peer Review: 

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using madLib.Models;

namespace madLib.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : Controller
    {
       [HttpPost("madlib")]

       public string story(madLibModel item)
       {
        return $"{item.name} went to meet up with {item.name2} at their meething time of {item.time} so they could go to {item.place} together.\n While there, they found {item.item} they werent sure what to do with it.\n ...\n So they took it to {item.wizard} the wizard! he has seen this item before.\n {item.wizard} casts {item.magicSpell} a spell capable of identifying the purpose of an item aswell as where it came from.\n Sadly the spell was cut short as the wizard was low on power, he could restore his power with {item.wizardFamiliar} a magic companion capible of assisting and enhancing magical power.\n The wizard than casts the spell again with an explotion of magic energy leaving the object {item.consistency}.\n {item.name} ask {item.wizard} why this is the case, he explains that there are some side affects. {item.name} and {item.name2} look at eachother each understanding what they must do next with their newly {item.consistency} item.\n you take it to {item.liquid} lake and toss the item in expecting to be rewarded.\n The {item.consistency} {item.item} interacts with the {item.liquid} in such a way that it causes a rift to be created within the area swallowing up both the {item.item} and the {item.liquid} from the lake\n left behind is a lone glowing egg, {item.name2} is frustrated with {item.name}'s actions for a moment before picking up the egg and taking it home.";
        
       }
    }
}