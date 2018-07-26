import React from 'react';
import {
  AppRegistry,
  asset,
  Pano,
  Text,
  View,
  Model,
  Animated,
} from 'react-vr';

const AnimatedModel = Animated.createAnimatedComponent(Model);

export default class WelcomeToVR extends React.Component {
	state = {
		bounceValue: new Animated.Value(0)
	}
	
	componentDidMount() {
    this.rotate();
  }
	
	rotate(){
    Animated.spring(
      this.state.bounceValue,
      {
        toValue: 400,
        duration: 10,
      }
    ).start(this.rotate);
  }
	
  render() {
    return (
      <View>
        <Pano source={asset('space-good.jpg')}/>
        
		<AnimatedModel style={{ 
		color: '#af1e23',
		transform: [ {
				translate: [0, 0, -10]}, 
				{rotateZ: this.state.bounceValue}
				 ], }
				} 	
				source={{obj:asset('astronaut.obj'), mtl:asset('astronaut.mtl') }} lit={true} />
		
		
      </View>
    );
  }
};

AppRegistry.registerComponent('WelcomeToVR', () => WelcomeToVR);
