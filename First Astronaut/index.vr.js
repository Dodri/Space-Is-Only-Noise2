import React from 'react'; 
import { 
AppRegistry, 
asset, 
StyleSheet, 
Pano, 
Text, 
View, 
Model, 
AmbientLight,
} from 'react-vr'; 

class WelcomeToVR extends React.Component { 

 constructor() { 
 super(); 
 this.state = { 
 rotation: 130, 
 }; 
 
 this.lastUpdate = 
 Date.now(); 
 this.rotate = this.rotate.bind(this); } 
 
  componentDidMount() { 
  this.rotate(); } 
  componentWillUnmount() { 
  
  if (this.frameHandle) { 
  cancelAnimationFrame(this.frameHandle); 
  this.frameHandle = null; 
  } 
  }
 
 rotate() { 
 const now = Date.now(); 
 const delta = now - this.lastUpdate; 
 this.lastUpdate = now; this.setState({
	 rotation: this.state.rotation + delta / 150 }); 
	 this.frameHandle = requestAnimationFrame(this.rotate); 
	 }

 
render() {

return ( 
<View> 
<Pano source={
	asset('space-good.jpg')
	}
/>

<AmbientLight intensity={ 2.6 }  
/>

        <Model style={{ 
		transform: [ {
				translate: [-25, 0, -30]}, 
				{scale: 0.15 }, 
				{rotateY: this.state.rotation}, 
				{rotateX: 20}, 
				{rotateZ: -10} ], }
				} 	
				source={{obj:asset('astronaut.obj'), mtl:asset('astronaut.mtl')}} lit={true} />


</View> 
); 
} 
};


AppRegistry.registerComponent('WelcomeToVR', () => WelcomeToVR);